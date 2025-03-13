using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Solution
{
    internal class Program6
    {
        public double CalculateArea(int side)
        {
            return side * side;
        }

        public double CalculateArea(int length, int width)
        {
            return length * width;
        }

        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
