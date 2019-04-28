using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseVarAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example1 
            var v = new { Amount = 101, Message = "     Hello World , The First Program Written By Sir dennis ritchie" };
            Console.WriteLine("Example1       ");
            Console.WriteLine(v.Amount + v.Message);


           // Example2
            string[] Arr = { "Shiv", "Raju", "Koirala", "Anil", "Amitabh" };
            var o = from x in Arr where x.Length > 4 select new { Len = x.Length, value = x };
            Console.WriteLine("Example2       ");
            foreach (var x in o)
            {
                Console.WriteLine(x.ToString());
            }

            Console.ReadLine();
        }
    }
}
