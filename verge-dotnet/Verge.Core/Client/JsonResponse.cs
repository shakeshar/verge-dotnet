using System.Net.Http;
using Verge.Core.Contract;

namespace Verge.Core.Client
{
    public class JsonResponse<T> : IJsonResponse<T>
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
    public class JsonErrorResponse<T> : IJsonResponse<T>
    {
        public HttpResponseMessage Response { get; }
        public T Data { get; }
        public string Message { get; }
        public JsonErrorResponse(HttpResponseMessage response, T data, string message)
        {
            Response = response;
            Data = data;
        }
    }
}
