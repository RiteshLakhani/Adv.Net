using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Solution
{
    public delegate T CalculatorDelegate<T>(T x, T y);
    internal class Cal
    {
        public static int Add(int x , int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
             return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            if(y!=0)
            {
                return x / y;
            }
            else
            {
                throw new Exception("Cannot divide by zero");
            }
        }
    }
}
