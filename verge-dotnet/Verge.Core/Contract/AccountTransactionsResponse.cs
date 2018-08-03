using System;
using System.Collections.Generic;
using System.Text;

namespace Verge.Core.Contract
{

    public class AccountTransactionsResponse
    {
        public string account { get; set; }
        public string address { get; set; }
        public string category { get; set; }
        public double amount { get; set; }
        public double fee { get; set; }
        public int confirmations { get; set; }
        public string blockhash { get; set; }
        public long blockindex { get; set; }
        public long blocktime { get; set; }
        public string txid { get; set; }
        public long time { get; set; }
        public long timereceived { get; set; }
        public string comment { get; set; }
        public string n_0 { get; set; }
        public string n_1 { get; set; }
    }
}
