using System.Net.Http;
using System.Threading.Tasks;

namespace Verge.Core.Client
{
    public class GetRequest<T> : JsonRequest<T>, IRequestCommand
    {
        public GetRequest(HttpClient client, string url):base(client, url)
        {
        }
        public async override Task<HttpResponseMessage> Execute()
        {
            return await Client.GetAsync(Url);
        }
    }
}
