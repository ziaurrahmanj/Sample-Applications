using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example
{
    public class ProcessData
    {
        public int Process(int x, int y, BizRulesDelegate del)
        {
           return del(x, y);
        }
    }
}
