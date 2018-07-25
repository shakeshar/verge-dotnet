using System;
using System.Collections.Generic;
using System.Text;

namespace Verge.Core.Contract
{
    public class GetWorkResponse
    {
        public string midstate { get; set; }
        public string data { get; set; }
        public string hash1 { get; set; }
        public string target { get; set; }
    }
}
