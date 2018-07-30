using System.Net.Http;
using Verge.Core.Contract;

namespace Verge.Core.Client
{
    public interface IJsonResponse<T>
    {
        T Data { get; }
        string Message { get; }
        HttpResponseMessage Response { get; }
    }
}