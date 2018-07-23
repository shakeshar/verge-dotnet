using System.Threading.Tasks;
using Verge.Core.Contract;

namespace Verge.Core.Client
{
    public interface IVergeClient
    {
        Task<JsonResponse<RootObject<object>>> GetConnectionCount();
        Task<JsonResponse<RootObject<GetInfoResponse>>> GetInfo();
        Task<JsonResponse<RootObject<object>>> getAccountAddress(string address);
        Task<JsonResponse<RootObject<object>>> getAccount(string account);
        Task<JsonResponse<RootObject<object>>> getBalance();
        Task<JsonResponse<RootObject<object>>> getAddressesByAccount();

        Task<JsonResponse<RootObject<object>>> getblockcount();
        Task<JsonResponse<RootObject<object>>> getdifficulty();
        Task<JsonResponse<RootObject<object>>> getgenerate();
        Task<JsonResponse<RootObject<object>>> gethashespersec();
        Task<JsonResponse<RootObject<object>>> getmemorypool();
        Task<JsonResponse<RootObject<object>>> getmininginfo();
        Task<JsonResponse<RootObject<object>>> walletlock();


    }
}