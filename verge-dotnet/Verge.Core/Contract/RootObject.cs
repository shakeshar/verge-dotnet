using System.Runtime.Serialization;

namespace Verge.Core.Contract
{
    [DataContract]
    public class RootObject<T>
    {
        [DataMember(Name = "result")]
        public T result { get; set; }
        [DataMember(Name = "error")]
         public RPCErrorResponse Error { get; set; }
        [DataMember(Name = "id")]
        public object id { get; set; }
    }
}
