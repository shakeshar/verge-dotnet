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
        private string address => "D7bLi4WtdExPHcK7UqAEWM33hrUimQ5gC7";
        private string account => "test2";
        private string walletBackupPath => @"C:\temp\wallet.bak";
        private string message => "test message";
        private decimal txFee => 0.01m;
        private string passphase => "supersecret";
        private string txId => "bddd6b9a5a47e2db90d4641fba9fcf871f9f78efede03eaf1dd4750c480ebef2";
        private string signMessage => "IJ8YlVVGIKsC+y2a7aKRAL2TjLVs9m8UD4zwlBfxhsXyfJGwZnpj5TWj+wiYSo3Dt5MRt0PVwm6KeS0ndM73AVk=";
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
        [Fact]
        public async Task assert_can_backupWallet()
        {
            var response = await client.backupWallet(walletBackupPath);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_dumpPrivKey()
        {
            var response = await client.dumpprivkey(address);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        //[Fact]
        //public async Task assert_can_encryptWallet()
        //{
        //    var response = await client.encryptwallet(passphase);
        //    Assert.True(response.Response.IsSuccessStatusCode);
        //}

        [Fact]
        public async Task assert_can_getreceivedbyaccount()
        {
            var response = await client.getreceivedbyaccount(account);
            Assert.True(response.Response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task assert_can_getreceivedbyaddress()
        {
            var response = await client.getreceivedbyaddress(address);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getTransaction()
        {
            var response = await client.getTransaction(txId);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getAccount()
        {
            var response = await client.getAccount(address);
            Assert.True(response.Response.IsSuccessStatusCode);

        }
             [Fact]
        public async Task assert_can_getWork()
        {
            var response = await client.getWork();
            Assert.True(response.Response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task assert_can_setAccount()
        {
            var response = await client.setAccount(address, account);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_setgenerate()
        {
            var response = await client.setgenerate(false, 1);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_signmessage()
        {
            var response = await client.signmessage(address, message);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_settxfee()
        {
            var response = await client.settxfee(txFee);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        //[Fact]
        //public async Task assert_can_stop()
        //{
        //    var response = await client.stop();
        //    Assert.True(response.Response.IsSuccessStatusCode);
        //}
        [Fact]
        public async Task assert_can_validateaddress()
        {
            var response = await client.validateaddress(address);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_verifymessage()
        {
            var response = await client.verifymessage(address, signMessage, message);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_unlockWallet()
        {
            var response = await client.walletUnlock(passphase, 10);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
    }
}
