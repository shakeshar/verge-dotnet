using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Verge.Core;
using Verge.Core.Client;
using Verge.Core.Contract;

using Xunit;

namespace Verge.Test.Integrations
{
    public class AccountTest : BaseTest
    {
        protected string signMessage => "IJ8YlVVGIKsC+y2a7aKRAL2TjLVs9m8UD4zwlBfxhsXyfJGwZnpj5TWj+wiYSo3Dt5MRt0PVwm6KeS0ndM73AVk=";
        protected string message => "test message";
        protected string txId => "9987fb3463d9b1adb77f70d4dde639f6006eef2cac3170da087bbc3d1d1c40f2";
       
        protected string walletBackupPath => @"C:\temp\wallet.bak";

        private readonly IAccount account;
        
        public AccountTest()
        {
            var appsettings = DILocator.Resolve<IAppSettings>();
            account = new Account()
            {
                Address = appsettings.GetValue<string>("address"),
                 Name = appsettings.GetValue<string>("account")
            };
        }
        [Fact]
        public async Task assert_can_backupWallet()
        {
            var response = await client.BackupWallet(walletBackupPath);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_dumpPrivKey()
        {           
            var response = await client.Dumpprivkey(account.Address);
            Assert.True(response.Response.IsSuccessStatusCode, response.Message);
        }
        [Fact]
        public async Task assert_can_getreceivedbyaccount()
        {
            var response = await client.GetReceivedByaccount(account.Name);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getreceivedbyaddress()
        {
            var response = await client.GetReceivedByAddress(account.Address);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getTransaction()
        {
            var response = await client.GetTransaction(txId);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getAccount()
        {
            var response = await client.GetAccount(account.Address);
            Assert.True(response.Response.IsSuccessStatusCode);

        }
        [Fact]
        public async Task assert_can_setAccount()
        {
            var response = await client.SetAccount(account.Address, account.Name);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_signmessage()
        {
            var response = await client.Signmessage(account.Address, message);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_validateaddress()
        {
            var response = await client.Validateaddress(account.Address);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_verifymessage()
        {
            var response = await client.Verifymessage(account.Address, signMessage, message);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_listTransactions()
        {
            var response = await client.ListTransactions(account.Name);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Theory]
        [InlineData("aHash")]
        public async Task assert_can_listSinceBlock(string blockHash)
        {
            var response = await client.ListSinceBlock(blockHash);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_listReceivedByAddress()
        {
            var response = await client.ListReceivedByAddress();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_listReceivedByAccount()
        {
            var response = await client.ListReceivedByAccount();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_listAccount()
        {
            var response = await client.ListAccounts();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Theory]
        [InlineData("key", "label")]
        public async Task assert_can_ImportPrivKey(string key, string label)
        {
            var response = await client.ImportPrivKey(key, label);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getNewAddress()
        {
            var response = await client.GetNewAddress();
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Theory]
        [InlineData(1)]
        public async Task assert_can_getBlockHash(int index)
        {
            var response = await client.GetBlockHash(index);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Theory]
        [InlineData("b4dd4dc662c8497d24483c6afdedc7d0f26260d3ff988ef0861ad4d7ef1f82ae")]
        public async Task assert_can_getBlock(string hash)
        {
            var response = await client.GetBlock(hash);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getAddresssByAccount()
        {
            var response = await client.GetAddressesByAccount(account.Name);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_getAccountAddress()
        {
            var response = await client.GetAccountAddress(account.Address);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
    }
}
