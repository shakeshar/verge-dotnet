using System;
using System.Collections.Generic;
using System.Text;

namespace Verge.Core.Contract
{
    public class TransactionResponse
    {
        public string txid { get; set; }
        public int version { get; set; }
        public int locktime { get; set; }
        public List<VinResponse> vin { get; set; }
        public List<VoutResponse> vout { get; set; }
        public string blockhash { get; set; }
        public int confirmations { get; set; }
        public int txntime { get; set; }
        public int time { get; set; }
    }
    public class ScriptSigResponse
    {
        public string asm { get; set; }
        public string hex { get; set; }
    }

    public class VinResponse
    {
        public string txid { get; set; }
        public int vout { get; set; }
        public ScriptSigResponse scriptSig { get; set; }
        public object sequence { get; set; }
    }

    public class ScriptPubKeyResponse
    {
        public string asm { get; set; }
        public string hex { get; set; }
        public int reqSigs { get; set; }
        public string type { get; set; }
        public List<string> addresses { get; set; }
    }

    public class VoutResponse
    {
        public double value { get; set; }
        public int n { get; set; }
        public ScriptPubKeyResponse scriptPubKey { get; set; }
    }
}
