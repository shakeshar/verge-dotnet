using System.Threading.Tasks;
using Verge.Core.Contract;

namespace Verge.Core.Client
{
    public interface IVergeClient
    {
        Task<JsonResponse<RootObject<object>>> GetConnectionCount();
        Task<JsonResponse<RootObject<GetInfoResponse>>> GetInfo();
        Task<JsonResponse<RootObject<object>>> getAccountAddress(string address);
        Task<JsonResponse<RootObject<object>>> getAccount(string address);
        Task<JsonResponse<RootObject<object>>> getBalance();
        Task<JsonResponse<RootObject<object>>> getTransaction(string txid);
        Task<JsonResponse<RootObject<object>>> getAddressesByAccount();
        Task<JsonResponse<RootObject<object>>> backupWallet(string filepath);
        Task<JsonResponse<RootObject<object>>> getblockcount();
        Task<JsonResponse<RootObject<object>>> getdifficulty();
        Task<JsonResponse<RootObject<object>>> getgenerate();
        Task<JsonResponse<RootObject<object>>> gethashespersec();
        Task<JsonResponse<RootObject<object>>> getmemorypool();
        Task<JsonResponse<RootObject<object>>> getmininginfo();
        Task<JsonResponse<RootObject<string>>> encryptwallet(string passphase);
        Task<JsonResponse<RootObject<string>>> encryptwallet(string oldpassphase, string newpassphrase);
        Task<JsonResponse<RootObject<object>>> walletlock();
        Task<JsonResponse<RootObject<string>>> dumpprivkey(string address);
        Task<JsonResponse<RootObject<string>>> getNewAddress();

        Task<JsonResponse<RootObject<object>>> getreceivedbyaccount(string account);
        Task<JsonResponse<RootObject<object>>> getreceivedbyaddress(string address);
        Task<JsonResponse<RootObject<object>>> getWork();
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