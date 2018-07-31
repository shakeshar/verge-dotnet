using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Verge.Core.Client;
using Verge.Core.Client.Commands;
using Verge.Core.Contract;
using Verge.Core.Contract.BlockExplorer;

namespace Verge.Core.Resource.BlockExplorer
{
    public class BlockExplorerResource : BaseHttpResource, IBlockExplorerResource
    {
        public BlockExplorerResource(HttpClient client, string baseUrl) : base(client, baseUrl)
        {
        
        }
        public async Task<IJsonResponse<BlockchainExplorerAddressBalanceResponse>> GetAddressBalance(string address)
        {
            string url = $"{BaseUrl}/ext/getaddress/{address}";
            JsonRequest<BlockchainExplorerAddressBalanceResponse> request = new GetRequest<BlockchainExplorerAddressBalanceResponse>(Client, url);
            return await request.Invoke();
        }
    }

    public interface IBlockExplorerResource
    {
        Task<IJsonResponse<BlockchainExplorerAddressBalanceResponse>> GetAddressBalance(string address);
    }
}
