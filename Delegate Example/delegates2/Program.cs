using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myListOfStrings =new List<string>() { "zia ", " bala", "rama " };
           var result= ListProcessor.ProcessList(myListOfStrings, str => str.Replace("a", "b"));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
        
}
