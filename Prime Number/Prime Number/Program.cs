using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    //Prime Number:If a number is divisible by 1 and itself is known as a PrimeNumber.Remember 2 is termed as even primenumber - See more at: http://pv999.blogspot.in/2013/07/1-n-prime-numbers.html#sthash.ZAWPOvyB.dpuf
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
          
            for(int i=3;i<num;i++)
            {
                PrimeNumber(i);
            }

            Console.ReadLine();

    }
        public  static void PrimeNumber(int num)
        {
            bool isPrime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                Console.WriteLine( num + " is a Prime Number");

            }
            else
            {
                Console.WriteLine(num + "is Not a Prime Number");
            }
        }

    }
}
