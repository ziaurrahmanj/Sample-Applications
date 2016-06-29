using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example
{
    public static class DelegateAsMethodParameter
    {
        // this method takes the delegate as parameter and uses it to
        // call the methods as required
        public static void SendString(MyDelegate m)
        {
            m(null, EventArgs.Empty);
        }
    }
  
}
