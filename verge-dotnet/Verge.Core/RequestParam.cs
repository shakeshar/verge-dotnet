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
        public string Params { get; set; }
        [DataMember(Name = "method")]
        public string Method { get; set; }

        public RPCRequest()
        {

        }
        //public RPCRequest()
        //{

        //}

        public Dictionary<string, object> Create()
        {
            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
            keyValuePairs.Add("id", Id);
            keyValuePairs.Add("params", Params);
            keyValuePairs.Add("method", Method);
            return keyValuePairs;
        } 
    }
}
