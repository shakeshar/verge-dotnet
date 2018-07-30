using System.Net.Http;
using Verge.Core.Contract;

namespace Verge.Core.Client
{
    public class JsonResponse<T> : IJsonResponse<T>
    { 
        public HttpResponseMessage Response { get; }
        public T Data { get; }
        public string Message => Response.ReasonPhrase;
        public string Content { get; }
        public JsonResponse(HttpResponseMessage response, T data, string content)
        {
            this.Response = response;
            this.Data = data;
            this.Content = content;
        }
    }
    public class JsonErrorResponse<T> : IJsonResponse<T>
    {
        public HttpResponseMessage Response { get; }
        public T Data { get; }
        public string Message { get; }
        public string Content { get; }

        public JsonErrorResponse(HttpResponseMessage response, T data, string message)
        {
            this.Response = response;
            this.Data = data;
        }
    }
}
