using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Verge.Core.Client;

namespace Verge.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello HODL!");
            IVergeClient client = new VergeClient("testuser", "testpass", "http://192.168.1.170", 20102);
            try
            {
                var response = client.GetInfo().Result;
                Console.WriteLine(response.Content);

                var balance = client.GetBalance().Result;
                Console.WriteLine(balance.Content);


                var accounts = client.ListAccounts().Result;



                var x= client.ListTransactions("*", 1000).Result;
                List<DateTimeOffset> items = new List<DateTimeOffset>();

                foreach (var item in x.Data.Result)
                {
                    var Date = DateTimeOffset.FromUnixTimeSeconds(item.timereceived);
                    items.Add(Date);    
                }
                var xxxx = client.WalletPassphrase("").Result;
             
              var priv =   client.Dumpprivkey("DQAFGhEwQ8W9aq4dqfetqGQ5coTviaFKdx").Result;



                Console.Read();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
    
}
