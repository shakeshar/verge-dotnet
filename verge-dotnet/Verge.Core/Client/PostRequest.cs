using System.Net.Http;
using System.Threading.Tasks;

namespace Verge.Core.Client
{
    public class PostRequest<T> : JsonRequest<T>, IRequestCommand
    {
        private object o;
        public PostRequest(HttpClient client, string url, object o) : base(client, url)
        {
            this.o = o;
        }
        public async override Task<HttpResponseMessage> Execute()
        {
            return await Client.PostAsync(Url, Create(o));
        }
    }
}
