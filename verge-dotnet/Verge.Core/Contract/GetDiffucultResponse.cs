using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Verge.Core.Contract
{

    [DataContract]
    public class GetDiffucultResponse
    {
        [DataMember(Name = "proof-of-stake-last-height")]
        public int ProofOfStakeLastHeight { get; set; }
        [DataMember(Name = "search-interval")]
        public int SearchInterval { get; set; }      
        [DataMember(Name = "proof-of-work-last-height")]
        public int ProofOfWorkLastHeight { get; set; }
        [DataMember(Name = "proof-of-stake")]
        public double ProofOfStake { get; set; }
        [DataMember(Name = "proof-of-stake-next")]
        public double ProofOfStakeNext { get; set; }
        [DataMember(Name = "proof-of-work")]
        public double ProofOfWork { get; set; }
        [DataMember(Name = "proof-of-work-next")]
        public double ProofOfWorkNext { get; set; }

    }
}
