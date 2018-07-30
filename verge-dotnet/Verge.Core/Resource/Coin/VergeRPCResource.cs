using System.Threading.Tasks;
using Verge.Core.Client;
using Verge.Core.Contract;

namespace Verge.Core.Resource.Coin
{
    public class VergeRPCResource : BitcoinRPCResource, IVergeRPCResource
    {
        
        public VergeRPCResource(string username, string password, string url, int port):base(username, password, url, port)
        {

        }
        public async Task<IJsonResponse<RootObject<object>>> stop()
        {
            var data = Create(RPCMethod.stop);
            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }

        public async Task<IJsonResponse<RootObject<object>>> sendfrom(string fromAccount, string tovergeaddress, decimal amount, string comment = "", string commentTo = "", int minConf = 1)
        {
            var data = Create(RPCMethod.sendFrom);
            data.AddParameter(fromAccount);
            data.AddParameter(tovergeaddress);
            data.AddParameter(amount);
            data.AddParameter(minConf);
            data.AddParameter(comment);
            data.AddParameter(commentTo);

            JsonRequest<RootObject<object>> request = new PostRequest<RootObject<object>>(client, $"{url}:{port}", data);
            return await request.Invoke();
        }
    }
    public interface IVergeRPCResource 
    {
        Task<IJsonResponse<RootObject<object>>> stop();
        Task<IJsonResponse<RootObject<object>>> sendfrom(string fromAccount, string tovergeaddress, decimal amount, string comment, string commentTo, int minConf);
    }
}
