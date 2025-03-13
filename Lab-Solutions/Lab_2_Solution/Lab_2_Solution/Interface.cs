using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Solution
{
    public interface Ical
    {
        int Add(int a, int b);
        int Sub(int x, int y);
    }
    internal class Interface : Ical
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int x, int y) 
        { 
            return x - y; 
        }
    }
}
