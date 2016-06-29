using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Check palindrome: ");
            string palindrome= Console.ReadLine();
            string reverse = new string (palindrome.Reverse().ToArray() );
           
            if(palindrome== reverse)
            {
                Console.WriteLine(" --Is a palindrome");
            }
            goto start;
           
        }
    }
}
