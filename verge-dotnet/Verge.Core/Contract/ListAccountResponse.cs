using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Verge.Core.Contract
{
    [DataContract]
    public class ListAccountResponse
    {
        public Dictionary<string, decimal> s { get; }
    }
}
