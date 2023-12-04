using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Appmilla.Yapily.Refit.Configuration;

namespace Appmilla.Yapily.Refit.Http
{
    public interface IYapilyHttpClientFactory
    {
        HttpClient CreateClient();
        void Reset();
    }
    
    public class YapilyHttpClientFactory : IYapilyHttpClientFactory
    {
        readonly IMessageHandlerFactory _messageHandlerFactory;
        readonly IYapilyConfiguration _yapilyConfiguration;
       
        HttpClient _httpClient;

        static readonly object SyncObject = new object();

        public YapilyHttpClientFactory(IMessageHandlerFactory messageHandlerFactory,
            IYapilyConfiguration yapilyConfiguration)
        {
            _messageHandlerFactory = messageHandlerFactory;
            _yapilyConfiguration = yapilyConfiguration;
        }

        public HttpClient CreateClient()
        {
            lock (SyncObject)
            {
                if (_httpClient != null)
                    return _httpClient;

                var innerHandler = _messageHandlerFactory.Create();
                var handler = new AuthenticatedParameterizedHttpClientHandler(
                    (request => Task.FromResult(_yapilyConfiguration.GetAuthorization())),
                            innerHandler);

                _httpClient = new HttpClient(handler) { BaseAddress = new Uri("https://api.yapily.com") };

                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                return _httpClient;
            }
        }

        public void Reset()
        {
            lock (SyncObject)
            {
                if (_httpClient != null)
                {
                    _httpClient.Dispose();
                    _httpClient = null;
                }
            }
        }

        class AuthenticatedParameterizedHttpClientHandler : DelegatingHandler
        {
            readonly Func<HttpRequestMessage, Task<string>> getToken;

            public AuthenticatedParameterizedHttpClientHandler(Func<HttpRequestMessage, Task<string>> getToken, HttpMessageHandler? innerHandler = null)
                : base(innerHandler ?? new HttpClientHandler())
            {
                this.getToken = getToken ?? throw new ArgumentNullException(nameof(getToken));
            }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                // See if the request has an authorize header
                var auth = request.Headers.Authorization;
                if (auth != null)
                {
                    var token = await getToken(request).ConfigureAwait(false);
                    request.Headers.Authorization = new AuthenticationHeaderValue(auth.Scheme, token);
                }

/*
                // see if the request has a consent header
                var consentHeaderPresent = request.Headers.Contains("consent");
                if (consentHeaderPresent)
                {
                    request.Headers.Remove("consent");
                    request.Headers.Add("consent", "XXXXXXX");
                }
  */
                return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            }
        }
    }
}