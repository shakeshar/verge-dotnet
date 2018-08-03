using System.Net.Http;
using System.Threading.Tasks;
using Verge.Core.Resource.BlockExplorer;
using Xunit;

namespace Verge.Test.Integrations
{

    public class BlockExplorerTest : BaseTest
    {
        IBlockExplorerResource resource;
        string address;
        public BlockExplorerTest()
        {
            HttpClient client = new HttpClient();
            string url = base.Settings.GetValue<string>("blockChainExplorerUrl");
            this.address = base.Settings.GetValue<string>("address");
            resource = new BlockExplorerResource(client, url);
        }

        
        
        [Fact]
        public async Task assert_can_getBalanceFromBlockExplorer()
        {
            var response = await resource.GetAddressBalance(address);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task test()
        {
            HttpClient client = new HttpClient();
            IBlockExplorerResource resource = new BlockExplorerResource(client, "https://verge-blockchain.info/");
            var result = await resource.GetAddressBalance("DMRQGQvToSbhGVbMh923e91FmYWoEkCq7W");
           
        }


    }
}
