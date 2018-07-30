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
    public class TransactionTest : BaseTest
    {
        protected decimal txFee => 0.1m;
        private Transaction From { get; }
        private Transaction To { get; }
        public TransactionTest()
        {
           
            var appsettings = DILocator.Resolve<IAppSettings>();
            From = new Transaction(
                appsettings.GetValue<string>("transactionFromAccount"),
                appsettings.GetValue<string>("transactionToAddress"),
                appsettings.GetDecimalValue("transactionAmount"),
                appsettings.GetValue<string>("transactionComment"),
                appsettings.GetValue<string>("transactionCommentTo"));
                
        }
        [Fact]
        public async Task assert_can_settxfee()
        {
            var response = await client.Settxfee(txFee);
            Assert.True(response.Response.IsSuccessStatusCode);
        }
        [Fact]
        public async Task assert_can_sendfrom()
        {
            //var txFeeResponse = await client.Settxfee(txFee);
            //Assert.True(txFeeResponse.Response.IsSuccessStatusCode, txFeeResponse.Message);
            //var response = await client.sendfrom(From.FromAccount, From.ToAdress, From.Amount, From.Comment, From.CommentTo, From.MinConf);
            //Assert.True(response.Response.IsSuccessStatusCode, response.Message);
        }

        
    }
}
