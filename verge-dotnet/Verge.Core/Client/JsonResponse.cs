using System.Net.Http;

namespace Verge.Core.Client
{
    public class JsonResponse<T>
    {
        public HttpResponseMessage Response { get; }
        public T Data { get; }
        public string Message => Response.ReasonPhrase;
        public JsonResponse(HttpResponseMessage response, T data)
        {
            Response = response;
            Data = data;
        }
       
    }
}
