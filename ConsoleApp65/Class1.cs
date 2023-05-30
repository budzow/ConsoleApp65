using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    internal class Class1 : Interface1
    {
        private int func(int i)
        {
            return i++;
        }

        public int myfunc(int i)
        {
            return func(i);
        }
    }

}
