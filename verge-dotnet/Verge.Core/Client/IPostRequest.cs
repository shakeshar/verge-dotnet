using System.Net.Http;
using System.Threading.Tasks;

namespace Verge.Core.Client
{
    public interface IRequestCommand
    {
        Task<HttpResponseMessage> Execute();
    }
}