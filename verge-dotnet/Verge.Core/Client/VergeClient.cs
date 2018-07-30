using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Verge.Core.Contract;
using Verge.Core.Resource.Coin;

namespace Verge.Core.Client
{

    public class VergeClient : VergeRPCResource, IVergeClient
    {
        public VergeClient(string username, string password, string url, int port):base(username, password, url, port)
        {
        }
        public VergeClient(IAppSettings settings)
            : base(settings.GetValue<string>("username"),
                 settings.GetValue<string>("password"),
                 settings.GetValue<string>("url"),
               Convert.ToInt32(settings.GetValue<long>("port")))
        {

        }
    } 
}
