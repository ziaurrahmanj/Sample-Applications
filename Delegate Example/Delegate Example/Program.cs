using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example
{
    //delegate declaration
    public delegate int BizRulesDelegate(int x, int y);
    public delegate void MyDelegate(object sender, EventArgs e);

   
    public class Program
    {
        static void Main(string[] args)
        {


            //*************************************
            //using lambdas with delegates
            BizRulesDelegate biz1 = (x, y) => x + y;
            BizRulesDelegate biz2 = (x, y) => x * y;
            ProcessData processData = new ProcessData();
            if (1 > 0)
                Console.WriteLine(processData.Process(10, 5, biz1));
            else
                processData.Process(10, 5, biz2);


            //**********************************************
            //delegate instantiation
            MyDelegate del1 = new MyDelegate(OnExecuting);
            MyDelegate del2 = new MyDelegate(OnCompleted);


            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
                //calling delegate
                del1(null, EventArgs.Empty);
            }
            //calling delegate
            del2(null, EventArgs.Empty);
            //*****************************************
            //delegate passed to method as parameter
            DelegateAsMethodParameter.SendString(del1);
            DelegateAsMethodParameter.SendString(del2);

            Console.ReadKey();

        }
        public static void OnExecuting(object sender,EventArgs e)
        {
            Console.WriteLine("Executing");

        }
        public static void OnCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Completed");

        }

    }
}
