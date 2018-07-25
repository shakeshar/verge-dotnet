using System.Threading.Tasks;
using Verge.Core.Contract;

namespace Verge.Core.Client
{
    public interface IVergeClient
    {
        Task<JsonResponse<RootObject<int>>> GetConnectionCount();
        Task<JsonResponse<RootObject<GetInfoResponse>>> GetInfo();
        Task<JsonResponse<RootObject<object>>> getAccountAddress(string address);
        Task<JsonResponse<RootObject<string>>> getAccount(string address);
        Task<JsonResponse<RootObject<decimal>>> getBalance();
        Task<JsonResponse<RootObject<TransactionResponse>>> getTransaction(string txid);
        Task<JsonResponse<RootObject<object>>> getAddressesByAccount();
        Task<JsonResponse<RootObject<object>>> backupWallet(string filepath);
        Task<JsonResponse<RootObject<long>>> getblockcount();
        Task<JsonResponse<RootObject<GetDiffucultResponse>>> getdifficulty();
        Task<JsonResponse<RootObject<bool>>> getgenerate();
        Task<JsonResponse<RootObject<double>>> gethashespersec();
        Task<JsonResponse<RootObject<object>>> getmemorypool();
        Task<JsonResponse<RootObject<object>>> getmininginfo();
        Task<JsonResponse<RootObject<string>>> encryptwallet(string passphase);
        Task<JsonResponse<RootObject<string>>> encryptwallet(string oldpassphase, string newpassphrase);
        Task<JsonResponse<RootObject<object>>> walletlock();
        Task<JsonResponse<RootObject<string>>> dumpprivkey(string address);
        Task<JsonResponse<RootObject<string>>> getNewAddress();

        Task<JsonResponse<RootObject<decimal>>> getreceivedbyaccount(string account);
        Task<JsonResponse<RootObject<decimal>>> getreceivedbyaddress(string address);
        Task<JsonResponse<RootObject<GetWorkResponse>>> getWork();
        Task<JsonResponse<RootObject<object>>> setAccount(string address, string account);
        Task<JsonResponse<RootObject<object>>> setgenerate(bool generate, int genproclimit = -1);
        Task<JsonResponse<RootObject<object>>> signmessage(string address, string message);
        Task<JsonResponse<RootObject<object>>> settxfee(decimal amount);
        Task<JsonResponse<RootObject<object>>> stop();
        Task<JsonResponse<RootObject<object>>> validateaddress(string address);
        Task<JsonResponse<RootObject<object>>> verifymessage(string address, string signature, string message);
        Task<JsonResponse<RootObject<object>>> walletUnlock(string passphase,  int timeoutSec);
    }
}