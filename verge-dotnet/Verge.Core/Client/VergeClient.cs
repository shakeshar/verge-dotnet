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
        public async Task<JsonResponse<RootObject<GetInfoResponse>>> GetConnectionCount()
        {
            var data = Create(RPCMethod.getConnectionCount);
            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        private Dictionary<string,object> Create(string method, string param = null)
        {
            var request = new RPCRequest() { Method = method.ToString(), Params = param };
            return request.Create();

        }

        public async Task<JsonResponse<RootObject<GetInfoResponse>>> getAccountAddress()
        {
            var data = Create(RPCMethod.getAccountAddress);
            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        public async Task<JsonResponse<RootObject<GetInfoResponse>>> getAccount()
        {
            var data = Create(RPCMethod.getAccount);
            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        public async Task<JsonResponse<RootObject<GetInfoResponse>>> getBalance()
        {
            var data = Create(RPCMethod.getBalance);
            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        public async Task<JsonResponse<RootObject<GetInfoResponse>>> getAddressesByAccount()
        {
            var data = Create(RPCMethod.getAddressesByAccount);
            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        public async Task<JsonResponse<RootObject<GetInfoResponse>>> getblocknumber()
        {
            var data = Create(RPCMethod.getBlock);
            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        public async Task<JsonResponse<RootObject<GetInfoResponse>>> getdifficulty()
        {
            var data = Create(RPCMethod.getDifficulty);
            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke(); 
        }

        public async Task<JsonResponse<RootObject<GetInfoResponse>>> getgenerate()
        {
            var data = Create(RPCMethod.getGenerate);
            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }

        public async Task<JsonResponse<RootObject<GetInfoResponse>>> gethashespersec()
        {
            var data = Create(RPCMethod.getHashesPerSec);
            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }

        public async Task<JsonResponse<RootObject<GetInfoResponse>>> getmemorypool()
        {
            var data = Create(RPCMethod.getMemoryPool);
            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }

        public async Task<JsonResponse<RootObject<GetInfoResponse>>> getmininginfo()
        {
            var data = Create(RPCMethod.getMiningInfo);
            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }

        public async Task<JsonResponse<RootObject<GetInfoResponse>>> walletlock()
        {
            var data = Create(RPCMethod.walletLock);
            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }
    }
}
