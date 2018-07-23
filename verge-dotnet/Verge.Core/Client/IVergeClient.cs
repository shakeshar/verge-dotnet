using System.Threading.Tasks;
using Verge.Core.Contract;

namespace Verge.Core.Client
{
    public interface IVergeClient
    {
        Task<JsonResponse<RootObject<GetInfoResponse>>> GetConnectionCount();
        Task<JsonResponse<RootObject<GetInfoResponse>>> GetInfo();
        Task<JsonResponse<RootObject<GetInfoResponse>>> getAccountAddress();
        Task<JsonResponse<RootObject<GetInfoResponse>>> getAccount();
        Task<JsonResponse<RootObject<GetInfoResponse>>> getBalance();
        Task<JsonResponse<RootObject<GetInfoResponse>>> getAddressesByAccount();

        Task<JsonResponse<RootObject<GetInfoResponse>>> getblocknumber();
        Task<JsonResponse<RootObject<GetInfoResponse>>> getdifficulty();
        Task<JsonResponse<RootObject<GetInfoResponse>>> getgenerate();
        Task<JsonResponse<RootObject<GetInfoResponse>>> gethashespersec();
        Task<JsonResponse<RootObject<GetInfoResponse>>> getmemorypool();
        Task<JsonResponse<RootObject<GetInfoResponse>>> getmininginfo();
        Task<JsonResponse<RootObject<GetInfoResponse>>> walletlock();


    }
}