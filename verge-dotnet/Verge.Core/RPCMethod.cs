using System;
using System.Collections.Generic;
using System.Text;

namespace Verge.Core
{
    public static class RPCMethod
    {
        public static string addMultiSigAddress => "addMultiSigAddress";

        public static string backupWallet => "backupWallet";
        public static string createRawTransaction => "createRawTransaction";
        public static string decodeRawTransaction => "decodeRawTransaction";
      
        public static string dumpPrivKey => "dumpPrivKey";
        public static string encryptWallet => "encryptWallet";
        public static string getAccount => "getAccount";
       
        public static string getAccountAddress => "getAccountAddress";
        public static string getAddressesByAccount => "getAddressesByAccount";
        public static string getBalance => "getBalance";

        public static string getBlock => "getBlock";
        public static string getBlockCount => "getBlockCount";
        public static string getBlockHash => "getBlockHash";
        public static string getConnectionCount => "getConnectionCount";
         
        public static string getDifficulty => "getDifficulty";
        public static string getGenerate => "getGenerate";
        public static string getHashesPerSec => "getHashesPerSec";

        public static string getInfo => "getInfo";
        public static string getMemoryPool => "getMemoryPool";
        public static string getMiningInfo => "getMiningInfo";

        public static string getNewAddress => "getNewAddress";
        public static string getRawTransaction => "getRawTransaction";
        public static string getReceivedByAccount => "getReceivedByAccount";

        public static string getReceivedByAddress => "getReceivedByAddress";
        public static string getTransaction => "getTransaction";
        public static string getWork => "getWork";

        public static string help => "help";
        public static string importPrivKey => "importPrivKey";
        public static string importAddress => "importAddress";

        public static string keyPoolRefill => "keyPoolRefill";
        public static string listAccounts => "listAccounts";
        public static string listReceivedByAccount => "listReceivedByAccount";

        public static string listReceivedByAddress => "listReceivedByAddress";
        public static string listSinceBlock => "listSinceBlock";
        public static string listTransactions => "listTransactions";

        public static string listUnspent => "listUnspent";
        public static string move => "move";
        public static string sendFrom => "sendFrom";

        public static string sendMany => "sendMany";
        public static string sendRawTransaction => "sendRawTransaction";
        public static string sendToAddress => "sendToAddress";

        public static string setAccount => "setAccount";
        public static string setGenerate => "setGenerate";
        public static string setTxFee => "setTxFee";

        public static string signMessage => "signMessage";
        public static string signRawTransaction => "signRawTransaction";
        public static string stop => "stop";
        public static string validateAddress => "validateAddress";
        public static string verifyMessage => "verifyMessage";

        public static string walletLock => "walletLock";
        public static string walletPassphrase => "walletPassphrase";
        public static string walletPassphraseChange => "walletPassphraseChange";
     
    }
}
