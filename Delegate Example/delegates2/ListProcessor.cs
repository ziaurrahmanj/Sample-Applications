using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates2
{//https://www.velir.com/blog/2011/07/14/how-improve-code-reusability-using-c-delegates
    public class ListProcessor
    {
        public delegate string StringProcessor(string str);
        public static List<string> ProcessList(List<string> strings,StringProcessor processor)
        {
            List<string> newList = new List<string>();

            foreach(string str in strings)
            {
                newList.Add(processor(str));
            }
            return newList;

        }

        //private static string ProcessItem(string str)
        //{
        //    return str.Replace("a", "b");
        //}
    }
}
