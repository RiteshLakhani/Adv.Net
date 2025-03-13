using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Solution
{
    internal class Program4
    {
        public delegate int FactorialDelegate(int n);

        public static int Cal(int n)
        {
            if(n < 0)
            {
                throw new ArgumentException("Number must be non-negative");
            }

            if( n== 0 || n ==1 )
            {
                return 1;
            }

            return n * Cal(n - 1);
        }
    }
}
