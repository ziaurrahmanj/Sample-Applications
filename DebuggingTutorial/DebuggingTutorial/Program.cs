using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "orange", "banana" };
            for (int i = 0; i <= fruits.Length; i++)
            {
                Debug.WriteLine("value of i=" + i);
                Console.WriteLine(fruits[i]);
            }
            Console.ReadLine();
        }
    }
}
