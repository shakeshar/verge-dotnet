using System.Collections.Generic;
using System.Threading.Tasks;
using Verge.Core.Client;
using Verge.Core.Client.Commands;
using Verge.Core.Contract;

namespace Verge.Core.Resource.Coin
{
    public interface IBitcoinRPCResource
    {
        Task<IJsonResponse<RootObject<object>>> BackupWallet(string filepath);
        Task<IJsonResponse<RootObject<string>>> Dumpprivkey(string address);
        Task<IJsonResponse<RootObject<string>>> Encryptwallet(string passphase);
        Task<IJsonResponse<RootObject<string>>> Encryptwallet(string oldpassphase, string newpassphrase);
        Task<IJsonResponse<RootObject<string>>> GetAccount(string address);
        Task<IJsonResponse<RootObject<object>>> GetAccountAddress(string address);
        Task<IJsonResponse<RootObject<object>>> GetAddressesByAccount(string account);
        Task<IJsonResponse<RootObject<decimal>>> GetBalance();
        Task<IJsonResponse<RootObject<object>>> GetBlock(string account);
        Task<IJsonResponse<RootObject<long>>> GetBlockCount();
        Task<IJsonResponse<RootObject<object>>> GetBlockHash(int index);
        Task<IJsonResponse<RootObject<int>>> GetConnectionCount();
        Task<IJsonResponse<RootObject<GetDiffucultResponse>>> Getdifficulty();
        Task<IJsonResponse<RootObject<bool>>> Getgenerate();
        Task<IJsonResponse<RootObject<double>>> GetHashesPerSec();
        Task<IJsonResponse<RootObject<GetInfoResponse>>> GetInfo();
        Task<IJsonResponse<RootObject<object>>> GetMemorypool();
        Task<IJsonResponse<RootObject<object>>> Getmininginfo();
        Task<IJsonResponse<RootObject<string>>> GetNewAddress();
        Task<IJsonResponse<RootObject<decimal>>> GetReceivedByaccount(string account);
        Task<IJsonResponse<RootObject<decimal>>> GetReceivedByAddress(string address);
        Task<IJsonResponse<RootObject<TransactionResponse>>> GetTransaction(string txid);
        Task<IJsonResponse<RootObject<GetWorkResponse>>> GetWork();
        Task<IJsonResponse<RootObject<object>>> ImportPrivKey(string key, string label);
        Task<IJsonResponse<RootObject<Dictionary<string, decimal>>>> ListAccounts();
        Task<IJsonResponse<RootObject<object>>> ListReceivedByAccount(int minConf = 1, bool includeEmpty = false);
        Task<IJsonResponse<RootObject<object>>> ListReceivedByAddress(int minConf = 1, bool includeEmpty = false);
        Task<IJsonResponse<RootObject<object>>> ListSinceBlock(string blockhash);
        Task<IJsonResponse<RootObject<IEnumerable<AccountTransactionsResponse>>>> ListTransactions(string account, int count = 10, int from = 0);
        Task<IJsonResponse<RootObject<object>>> Move(string fromAccount, string toAccount, decimal amount, string comment, int minConf = 1);
        Task<IJsonResponse<RootObject<object>>> SendToAddress(string address, decimal amount, string comment, string commentTo);
        Task<IJsonResponse<RootObject<object>>> SetAccount(string address, string account);
        Task<IJsonResponse<RootObject<object>>> Setgenerate(bool generate, int genproclimit = -1);
        Task<IJsonResponse<RootObject<bool>>> Settxfee(decimal amount);
        Task<IJsonResponse<RootObject<object>>> Signmessage(string address, string message);
        Task<IJsonResponse<RootObject<object>>> Validateaddress(string address);
        Task<IJsonResponse<RootObject<object>>> Verifymessage(string address, string signature, string message);
        Task<IJsonResponse<RootObject<object>>> Walletlock();
        Task<IJsonResponse<RootObject<object>>> WalletPassphrase(string passphase, int timeoutSec = 1073741824);
        Task<IJsonResponse<RootObject<object>>> WalletPassphraseChange(string oldPassphrase, string newPassphrase);

    }

    public class BitcoinRPCResource : BaseBitcoin, IBitcoinRPCResource
    {
        public BitcoinRPCResource(string username, string password, string url, int port):base(username, password, url, port)
        {

        }
        public async Task<IJsonResponse<RootObject<object>>> BackupWallet(string filepath)
        {

            var data = Create(RPCMethod.backupWallet);
            data.AddParameter(filepath);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<string>>> Dumpprivkey(string address)
        {
            var data = Create(RPCMethod.dumpPrivKey);
            data.AddParameter(address);
            JsonRequest<RootObject<string>> request = new PostRequest<RootObject<string>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<string>>> Encryptwallet(string passphase)
        {
            var data = Create(RPCMethod.encryptWallet);
            data.AddParameter(passphase);
            JsonRequest<RootObject<string>> request = new PostRequest<RootObject<string>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<string>>> Encryptwallet(string oldpassphase, string newpassphrase)
        {
            var data = Create(RPCMethod.walletPassphraseChange);
            data.AddParameter(oldpassphase);
            data.AddParameter(newpassphrase);
            JsonRequest<RootObject<string>> request = new PostRequest<RootObject<string>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<string>>> GetAccount(string address)
        {
            var data = Create(RPCMethod.getAccount);
            data.AddParameter(address);
            JsonRequest<RootObject<string>> request = new PostRequest<RootObject<string>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> GetAccountAddress(string address)
        {
            var data = Create(RPCMethod.getAccountAddress);
            data.AddParameter(address);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> GetAddressesByAccount(string account)
        {
            var data = Create(RPCMethod.getAddressesByAccount);
            data.AddParameter(account);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<decimal>>> GetBalance()
        {
            var data = Create(RPCMethod.getBalance);
            JsonRequest<RootObject<decimal>> request = new PostRequest<RootObject<decimal>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> GetBlock(string account)
        {
            var data = Create(RPCMethod.getBlock);
            data.AddParameter(account);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<long>>> GetBlockCount()
        {
            var data = Create(RPCMethod.getBlockCount);
            JsonRequest<RootObject<long>> request = new PostRequest<RootObject<long>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> GetBlockHash(int index)
        {
            var data = Create(RPCMethod.getBlockHash);
            data.AddParameter(index);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<int>>> GetConnectionCount()
        {
            var data = Create(RPCMethod.getConnectionCount);
            JsonRequest<RootObject<int>> request = new PostRequest<RootObject<int>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<GetDiffucultResponse>>> Getdifficulty()
        {
            var data = Create(RPCMethod.getDifficulty);
            JsonRequest<RootObject<GetDiffucultResponse>> request = new PostRequest<RootObject<GetDiffucultResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<bool>>> Getgenerate()
        {
            var data = Create(RPCMethod.getGenerate);
            JsonRequest<RootObject<bool>> request = new PostRequest<RootObject<bool>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }
        public async Task<IJsonResponse<RootObject<double>>> GetHashesPerSec()
        {
            var data = Create(RPCMethod.getHashesPerSec);
            JsonRequest<RootObject<double>> request = new PostRequest<RootObject<double>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }
        public async Task<IJsonResponse<RootObject<GetInfoResponse>>> GetInfo()
        {
            var data = Create(RPCMethod.getInfo);

            JsonRequest<RootObject<GetInfoResponse>> request = new PostRequest<RootObject<GetInfoResponse>>(client, $"{url}:{port}", data);
            
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> GetMemorypool()
        {
            var data = Create(RPCMethod.getMemoryPool);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }
        public async Task<IJsonResponse<RootObject<object>>> Getmininginfo()
        {
            var data = Create(RPCMethod.getMiningInfo);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke(); ;
        }
        public async Task<IJsonResponse<RootObject<string>>> GetNewAddress()
        {
            var data = Create(RPCMethod.getNewAddress);
            JsonRequest<RootObject<string>> request = new PostRequest<RootObject<string>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<decimal>>> GetReceivedByaccount(string account)
        {
            var data = Create(RPCMethod.getReceivedByAccount);
            data.AddParameter(account);

            JsonRequest<RootObject<decimal>> request = new PostRequest<RootObject<decimal>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<decimal>>> GetReceivedByAddress(string address)
        {
            var data = Create(RPCMethod.getReceivedByAddress);
            data.AddParameter(address);
            JsonRequest<RootObject<decimal>> request = new PostRequest<RootObject<decimal>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<TransactionResponse>>> GetTransaction(string txid)
        {
            var data = Create(RPCMethod.getTransaction);
            data.AddParameter(txid);
            JsonRequest<RootObject<TransactionResponse>> request = new PostRequest<RootObject<TransactionResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<GetWorkResponse>>> GetWork()
        {
            var data = Create(RPCMethod.getWork);
            JsonRequest<RootObject<GetWorkResponse>> request = new PostRequest<RootObject<GetWorkResponse>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> ImportPrivKey(string key, string label)
        {
            var data = Create(RPCMethod.importPrivKey);
            data.AddParameter(key);
            data.AddParameter(label);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<Dictionary<string, decimal>>>> ListAccounts()
        {
            var data = Create(RPCMethod.listAccounts);
            JsonRequest<RootObject<Dictionary<string,decimal>>> request = new PostRequest<RootObject<Dictionary<string, decimal>>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> ListReceivedByAccount(int minConf = 1, bool includeEmpty = false)
        {
            var data = Create(RPCMethod.listReceivedByAccount);
            data.AddParameter(minConf);
            data.AddParameter(includeEmpty);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> ListReceivedByAddress(int minConf = 1, bool includeEmpty = false)
        {
            var data = Create(RPCMethod.listReceivedByAddress);
            data.AddParameter(minConf);
            data.AddParameter(includeEmpty);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> ListSinceBlock(string blockhash)
        {
            var data = Create(RPCMethod.listSinceBlock);
            data.AddParameter(blockhash);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<IEnumerable<AccountTransactionsResponse>>>> ListTransactions(string account, int count = 10, int from = 0)
        {
            var data = Create(RPCMethod.listTransactions);
            data.AddParameter(account);
            data.AddParameter(count);
            data.AddParameter(from);
            JsonRequest<RootObject<IEnumerable<AccountTransactionsResponse>>> request = new PostRequest<RootObject<IEnumerable<AccountTransactionsResponse>>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> Move(string fromAccount, string toAccount, decimal amount, string comment, int minConf = 1)
        {
            var data = Create(RPCMethod.move);
            data.AddParameter(fromAccount);
            data.AddParameter(toAccount);
            data.AddParameter(amount);
            data.AddParameter(minConf);
            data.AddParameter(comment);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> SendToAddress(string address, decimal amount, string comment, string commentTo)
        {
            var data = Create(RPCMethod.sendToAddress);
            data.AddParameter(address);
            data.AddParameter(amount);
            data.AddParameter(comment);
            data.AddParameter(commentTo);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> SetAccount(string address, string account)
        {
            var data = Create(RPCMethod.setAccount);
            data.AddParameter(address);
            data.AddParameter(account);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> Setgenerate(bool generate, int genproclimit = -1)
        {
            var data = Create(RPCMethod.setGenerate);
            data.AddParameter(generate);
            data.AddParameter(genproclimit);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<bool>>> Settxfee(decimal amount)
        {
            var data = Create(RPCMethod.setTxFee);
            data.AddParameter(amount);
            JsonRequest<RootObject<bool>> request = new PostRequest<RootObject<bool>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> Signmessage(string address, string message)
        {
            var data = Create(RPCMethod.signMessage);
            data.AddParameter(address);
            data.AddParameter(message);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> Validateaddress(string address)
        {
            var data = Create(RPCMethod.validateAddress);
            data.AddParameter(address);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> Verifymessage(string address, string signature, string message)
        {
            var data = Create(RPCMethod.verifyMessage);
            data.AddParameter(address);
            data.AddParameter(signature);
            data.AddParameter(message);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> Walletlock()
        {
            var data = Create(RPCMethod.walletLock);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> WalletPassphrase(string passphase, int timeoutSec = 10)
        {
            var data = Create(RPCMethod.walletPassphrase);
            data.AddParameter(passphase);
            data.AddParameter(timeoutSec);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);

            return await request.Invoke();
        }
        public async Task<IJsonResponse<RootObject<object>>> WalletPassphraseChange(string oldPassphrase, string newPassphrase)
        {
            var data = Create(RPCMethod.walletPassphraseChange);
            data.AddParameter(oldPassphrase);
            data.AddParameter(newPassphrase);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

       
    }
}
