using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Verge.Core
{   
    [DataContract]
    public class RPCRequest
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "params")]
        public IList<object> Params { get; set; }
        [DataMember(Name = "method")]
        public string Method { get; set; }

        public RPCRequest()
        {
            Params = new List<object>();
        }
        public void AddParameter(object param)
        {
            Params.Add(param);
        }
    }
}
