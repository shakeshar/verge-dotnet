using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Verge.Core.Resource.Coin
{
    public abstract class BaseBitcoin
    {
        public HttpClient client;
        public readonly string url;
        public readonly int port;
        public RPCRequest Create(string method, string id = "1")
        {
            var request = new RPCRequest() { Method = method.ToString().ToLower(), Id = id };
            return request;
        }
        public BaseBitcoin(string username, string password, string url, int port)
        {
            client = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            this.url = url;
            this.port = port;
        }
    }
}
