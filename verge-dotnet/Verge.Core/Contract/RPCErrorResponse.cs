using System.Runtime.Serialization;

namespace Verge.Core.Contract
{
    [DataContract]
    public class RPCErrorResponse
    {
        [DataMember(Name = "message")]
        public string Message { get; set; }
        [DataMember(Name = "code")]
        public int Code { get; set; }
    }
}
