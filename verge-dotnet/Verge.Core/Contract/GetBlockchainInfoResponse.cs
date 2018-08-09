using System;
using System.Collections.Generic;
using System.Text;

namespace Verge.Core.Contract
{
    public class GetBlockchainInfoResponse
    {
        public string chain { get; set; }
        public int blocks { get; set; }
        public int headers { get; set; }
        public string bestblockhash { get; set; }
        public double difficulty { get; set; }
        public int mediantime { get; set; }
        public double verificationprogress { get; set; }
        public bool initialblockdownload { get; set; }
        public string chainwork { get; set; }
        public long size_on_disk { get; set; }
        public bool pruned { get; set; }
        public List<Softfork> softforks { get; set; }
        public Bip9Softforks bip9_softforks { get; set; }
        public string warnings { get; set; }
    }
    public class Reject
    {
        public bool status { get; set; }
    }

    public class Softfork
    {
        public string id { get; set; }
        public int version { get; set; }
        public Reject reject { get; set; }
    }

    public class Csv
    {
        public string status { get; set; }
        public int startTime { get; set; }
        public int timeout { get; set; }
        public int since { get; set; }
    }

    public class Segwit
    {
        public string status { get; set; }
        public int startTime { get; set; }
        public int timeout { get; set; }
        public int since { get; set; }
    }

    public class Bip9Softforks
    {
        public Csv csv { get; set; }
        public Segwit segwit { get; set; }
    }

}
