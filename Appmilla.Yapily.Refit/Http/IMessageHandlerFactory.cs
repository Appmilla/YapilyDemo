using System.Net.Http;

namespace Appmilla.Yapily.Refit.Http
{
    public interface IMessageHandlerFactory
    {
        HttpMessageHandler Create();
    }
}