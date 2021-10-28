using System.Net.Http;
using Appmilla.Yapily.Refit.Http;

namespace YapilyDemo.iOS.Services.Http
{
    public class MessageHandlerFactory : IMessageHandlerFactory
    {
        public HttpMessageHandler Create()
        {
            return new NSUrlSessionHandler {
                DisableCaching = true,
                AllowAutoRedirect = false,
            };
        }
    }
}