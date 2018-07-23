using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Verge.Core.Contract;

namespace Verge.Core.Client
{

    public class VergeClient : IVergeClient
    {
        private HttpClient client;
        private readonly string url;
        private readonly int port;
        public VergeClient(string username, string password, string url, int port)
        {
            client = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            this.url = url;
            this.port = port;
        }

        public async Task<JsonResponse<RootObject<GetInfoResponse>>> GetInfo()
        {
            var data = Create(RPCMethod.getInfo);
          
            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<JsonResponse<RootObject<object>>> GetConnectionCount()
        {
            var data = Create(RPCMethod.getConnectionCount);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        private Dictionary<string,object> Create(string method, string[] param = null)
        {
            var request = new RPCRequest() { Method = method.ToString().ToLower(), Params = param };
            return request.Create();

        }

        public async Task<JsonResponse<RootObject<object>>> getAccountAddress(string address)
        {
            var data = Create(RPCMethod.getAccountAddress);
            RPCRequest r = new RPCRequest() { Method = RPCMethod.getInfo.ToLower(), Id = "1" };
            r.Params = new string[] { address };
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", r);
            return await request.Invoke();
        }

        public async Task<JsonResponse<RootObject<object>>> getAccount(string account)
        {
            var data = Create(RPCMethod.getAccount);
            
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        public async Task<JsonResponse<RootObject<object>>> getBalance()
        {
            var data = Create(RPCMethod.getBalance);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        public async Task<JsonResponse<RootObject<object>>> getAddressesByAccount()
        {
            var data = Create(RPCMethod.getAddressesByAccount);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        public async Task<JsonResponse<RootObject<object>>> getblockcount()
        {
            var data = Create(RPCMethod.getBlockCount);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        public async Task<JsonResponse<RootObject<object>>> getdifficulty()
        {
            var data = Create(RPCMethod.getDifficulty);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke(); 
        }

        public async Task<JsonResponse<RootObject<object>>> getgenerate()
        {
            var data = Create(RPCMethod.getGenerate);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }

        public async Task<JsonResponse<RootObject<object>>> gethashespersec()
        {
            var data = Create(RPCMethod.getHashesPerSec);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }

        public async Task<JsonResponse<RootObject<object>>> getmemorypool()
        {
            var data = Create(RPCMethod.getMemoryPool);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }

        public async Task<JsonResponse<RootObject<object>>> getmininginfo()
        {
            var data = Create(RPCMethod.getMiningInfo);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }

        public async Task<JsonResponse<RootObject<object>>> walletlock()
        {
            var data = Create(RPCMethod.walletLock);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }
    }
}
