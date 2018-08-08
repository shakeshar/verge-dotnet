using System.Threading.Tasks;
using Verge.Core;
using Verge.Core.Client;
using Xunit;

namespace Verge.Test.Integrations
{

    public class BaseTest
    {
        protected string passphase => "supersecret";
        protected readonly IVergeClient client;
        protected readonly IAppSettings Settings;
        public BaseTest()
        {
            Settings = DILocator.Resolve<IAppSettings>();
            this.client = DILocator.Resolve<IVergeClient>();
        }
        [Fact]
        public async Task assert_can_encryptWallet()
        {
            var response = await client.Encryptwallet(passphase);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Theory]
        [InlineData("SuperSecret")]
        public async Task assert_can_changePassphrase(string newPassphrase)
        {
            var response = await client.WalletPassphraseChange(passphase, newPassphrase);
            Assert.True(response.Response.IsSuccessStatusCode);
            response = await client.WalletPassphraseChange(newPassphrase, passphase);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_unlockWallet()
        {
            var response = await client.WalletPassphrase(passphase, false, 500);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
    }

    public class Account : IAccount
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public interface IAccount
    {
        string Address { get; }
        string Name { get; }
    }
}
