using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Verge.Core.Client;
using Verge.Core.Contract;

using Xunit;

namespace Verge.Test
{

    public class StatusTest :BaseTest
    {

        public StatusTest()
        {

        }
        
        [Fact]
        public async Task assert_can_getdifficulty()
        {
            var response = await client.Getdifficulty();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getgenerate()
        {
            var response = await client.Getgenerate();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getConnectionCount()
        {
            var response = await client.GetConnectionCount();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getmininginfo()
        {
            var response = await client.Getmininginfo();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_setgenerate()
        {
            var response = await client.Setgenerate(false, 1);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getWork()
        {
            var response = await client.GetWork();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getinfo()
        {
            var response = await client.GetInfo();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getBalance()
        {
            var response = await client.GetBalance();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getblocknumber()
        {
            var response = await client.GetBlockCount();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_gethashespersec()
        {
            var response = await client.GetHashesPerSec();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_stop()
        {
            //var response = await client.stop();
            //Assert.True(response.Response.IsSuccessStatusCode);
        }

    }
}
