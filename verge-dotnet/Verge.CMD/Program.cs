using System;
using System.Threading.Tasks;
using Verge.Core.Client;

namespace Verge.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello HODL!");
            IVergeClient client = new VergeClient("testuser", "testpass", "http://127.0.0.1", 20102);
            try
            {
                var response = client.GetInfo().Result;
                Console.WriteLine(response.Content);
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
