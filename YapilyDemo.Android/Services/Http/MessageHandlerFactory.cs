using System.Net;
using System.Net.Http;
using Appmilla.Yapily.Refit.Http;
using Xamarin.Android.Net;

namespace YapilyDemo.Droid.Services.Http
{
    public class MessageHandlerFactory : IMessageHandlerFactory
    {
        public HttpMessageHandler Create()
        {
            var handler = new AndroidYapilyClientHandler
            {
                InnerHandler = new AndroidClientHandler
                {
                    AllowAutoRedirect = false,
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                }
            };
            
            return handler;
        }
    }
}