using System.Net.Http;
using System.Threading.Tasks;

namespace Verge.Core.Client.Commands
{
    public interface IRequestCommand
    {
        Task<HttpResponseMessage> Execute();
    }
}