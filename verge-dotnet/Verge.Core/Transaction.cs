using System;
using System.Collections.Generic;
using System.Text;

namespace Verge.Core
{
    public class Transaction
    {
        public int MinConf { get; }
        public decimal Amount { get; }
        public string FromAccount { get; }
        public string ToAdress { get; }      
        public string Comment { get; }
        public string CommentTo { get; }

        public Transaction(string fromAccount, string toAddress, decimal amount, string comment = "", string commentTo = "", int minConf = 3)
        {
            this.FromAccount = fromAccount;
            this.ToAdress = toAddress;
            this.Amount = amount;
            this.Comment = comment;
            this.CommentTo = commentTo;
            this.MinConf = minConf;
        }
    }
}
