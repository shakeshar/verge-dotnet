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
        public async Task<JsonResponse<RootObject<object>>> getAccountAddress(string address)
        {
            var data = Create(RPCMethod.getAccountAddress);
            RPCRequest r = new RPCRequest() { Method = RPCMethod.getInfo.ToLower(), Id = "1" };
            r.Params = new string[] { address };
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", r);
            return await request.Invoke();
        }
        public async Task<JsonResponse<RootObject<object>>> getAccount(string address)
        {
            var data = Create(RPCMethod.getAccount);
            data.AddParameter(address);
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
            return await request.Invoke(); 
        }
        public async Task<JsonResponse<RootObject<object>>> getTransaction(string txid)
        {
            var data = Create(RPCMethod.getTransaction);
          
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke(); 
        }
        public async Task<JsonResponse<RootObject<object>>> backupWallet(string filepath)
        {

            var data = Create(RPCMethod.backupWallet);
            data.AddParameter(filepath);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke(); 
        }
        public async Task<JsonResponse<RootObject<string>>> dumpprivkey(string address)
        {
            var data = Create(RPCMethod.dumpPrivKey);
            data.AddParameter(address);
            JsonRequest<RootObject<string>> request = new PostRequest<RootObject<string>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<JsonResponse<RootObject<string>>> encryptwallet(string passphase)
        {
            var data = Create(RPCMethod.encryptWallet);
            data.AddParameter(passphase);
            JsonRequest<RootObject<string>> request = new PostRequest<RootObject<string>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<JsonResponse<RootObject<string>>> getNewAddress()
        {
            var data = Create(RPCMethod.getNewAddress);
            JsonRequest<RootObject<string>> request = new PostRequest<RootObject<string>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<JsonResponse<RootObject<object>>> getreceivedbyaccount(string account)
        {
            var data = Create(RPCMethod.getReceivedByAccount);
            data.AddParameter(account);

            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<JsonResponse<RootObject<object>>> getreceivedbyaddress(string address)
        {
            var data = Create(RPCMethod.getReceivedByAddress);
            data.AddParameter(address);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }


        private RPCRequest Create(string method, string id = "1")
        {
            var request = new RPCRequest() { Method = method.ToString().ToLower(), Id = id };
            return request;
        }

        public async Task<JsonResponse<RootObject<object>>> getWork()
        {
            var data = Create(RPCMethod.getWork);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<JsonResponse<RootObject<object>>> setAccount(string address, string account)
        {
            var data = Create(RPCMethod.setAccount);
            data.AddParameter(address);
            data.AddParameter(account);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }        
        public async Task<JsonResponse<RootObject<object>>> setgenerate(bool generate, int genproclimit = -1)
        {
            var data = Create(RPCMethod.setGenerate);
            data.AddParameter(generate);
            data.AddParameter(genproclimit);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<JsonResponse<RootObject<object>>> signmessage(string address, string message)
        {
            var data = Create(RPCMethod.signMessage);
            data.AddParameter(address);
            data.AddParameter(message);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<JsonResponse<RootObject<object>>> settxfee(decimal amount)
        {
            var data = Create(RPCMethod.setTxFee);
            data.AddParameter(amount);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<JsonResponse<RootObject<object>>> stop()
        {
            var data = Create(RPCMethod.stop);         
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<JsonResponse<RootObject<object>>> validateaddress(string address)
        {
            var data = Create(RPCMethod.validateAddress);
            data.AddParameter(address);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        public async Task<JsonResponse<RootObject<object>>> verifymessage(string address, string signature, string message)
        {
            var data = Create(RPCMethod.verifyMessage);
            data.AddParameter(address);
            data.AddParameter(signature);
            data.AddParameter(message);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        public async Task<JsonResponse<RootObject<string>>> encryptwallet(string oldpassphase, string newpassphrase)
        {
            var data = Create(RPCMethod.walletPassphraseChange);
            data.AddParameter(oldpassphase);
            data.AddParameter(newpassphrase);
            JsonRequest<RootObject<string>> request = new PostRequest<RootObject<string>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        public async Task<JsonResponse<RootObject<object>>> walletUnlock(string passphase, int timeoutSec = 10)
        {
            var data = Create(RPCMethod.walletPassphrase);
            data.AddParameter(passphase);
            data.AddParameter(timeoutSec);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
         
            return await request.Invoke();
        }
    }
}
