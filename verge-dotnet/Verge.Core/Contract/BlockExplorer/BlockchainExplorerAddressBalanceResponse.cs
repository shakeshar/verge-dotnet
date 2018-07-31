using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Verge.Core.Contract.BlockExplorer
{
    [DataContract]
    public class BlockchainExplorerAddressBalanceResponse
    {
        [DataMember(Name = "address")]
        public string address { get; set; }
        [DataMember]
        public double sent { get; set; }
        [DataMember]
        public double received { get; set; }
        [DataMember]
        public string balance { get; set; }
        [DataMember]
        public List<LastTx> last_txs { get; set; }
    }
    [DataContract]
    public class LastTx
    {
        [DataMember]
        public string addresses { get; set; }
        [DataMember]
        public string type { get; set; }
    }
}
