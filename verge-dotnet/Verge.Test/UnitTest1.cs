using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Verge.Core.Client;
using Verge.Core.Contract;
using Xunit;

namespace Verge.Test
{
    public class UnitTest1
    {
        IVergeClient client;
        private string username => "testuser";
        private string password => "testpass";
        private string url => "http://127.0.0.1";
        private int port => 20102;
        public UnitTest1()
        {
            client = new VergeClient(username, password, url, port);
        }

        [Fact]
        public async Task Assert_Can_GetInfo()
        {
            var response = await client.GetInfo();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task Assert_Can_getConnectionCount()
        {
            var response = await client.GetConnectionCount();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task Assert_Can_getAccountAddress()
        {
            var response = await client.getAccountAddress();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task Assert_Can_getAccount()
        {
            var response = await client.getAccount();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task Assert_Can_getBalance()
        {
            var response = await client.getBalance();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task Assert_Can_getblocknumber()
        {
            var response = await client.getblocknumber();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task Assert_Can_getdifficulty()
        {
            var response = await client.getdifficulty();
            Assert.True(response.Response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task Assert_Can_getgenerate()
        {
            var response = await client.getgenerate();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task Assert_Can_gethashespersec()
        {
            var response = await client.gethashespersec();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task Assert_Can_getmemorypool()
        {
            var response = await client.getmemorypool();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task Assert_Can_getmininginfo()
        {
            var response = await client.getmininginfo();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task Assert_Can_walletlock()
        {
            var response = await client.walletlock();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        private async Task Invoke(Action action)
        {
            try
            {
               action.Invoke();
            }
            catch (Exception e)
            {

            }
        }
    }
}
