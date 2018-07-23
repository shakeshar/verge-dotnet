using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Verge.Core.Client;
using Verge.Core.Contract;
using Xunit;

namespace Verge.Test
{
    public class IntegrationTest
    {
        IVergeClient client;
        private string username => "testuser";
        private string password => "testpass";
        private string url => "http://127.0.0.1";
        private int port => 20102;
        public IntegrationTest()
        {
            client = new VergeClient(username, password, url, port);
        }

        [Fact]
        public async Task assert_can_getinfo()
        {
            var response = await client.GetInfo();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getConnectionCount()
        {
            var response = await client.GetConnectionCount();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getBalance()
        {
            var response = await client.getBalance();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getblocknumber()
        {
            var response = await client.getblockcount();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getdifficulty()
        {
            var response = await client.getdifficulty();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getgenerate()
        {
            var response = await client.getgenerate();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_gethashespersec()
        {
            var response = await client.gethashespersec();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getmininginfo()
        {
            var response = await client.getmininginfo();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
    }
}
