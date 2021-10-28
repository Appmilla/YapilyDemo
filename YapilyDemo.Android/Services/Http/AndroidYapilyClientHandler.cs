using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Java.Net;

namespace YapilyDemo.Droid.Services.Http
{
    public class AndroidClientHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            try
            {
                return await base.SendAsync(request, cancellationToken);
            }
            catch (UnknownHostException)
            {
                // this is the same message text thrown by iOS so we can filter this out of app center errors
                throw new HttpRequestException("The Internet connection appears to be offline.");

                //Note please leave this as it is 
                //var message = exception.Message;
                //throw new HttpRequestException(message);

                //referencing the exception as below doesn't work
                //throw new HttpRequestException(exception.Message);
            }
        }
    }
}