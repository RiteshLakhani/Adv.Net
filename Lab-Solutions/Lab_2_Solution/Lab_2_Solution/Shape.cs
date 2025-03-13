using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Solution
{
    public interface ShapeCal
    {
        double Circle(double radius);
        double Triangle(double baseLength, double height);
        double Square(double sideLength);
    }
    internal class Shape : ShapeCal
    {
        public double Circle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double Triangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public double Square(double sideLength)
        {
            return sideLength * sideLength;
        }
    }
}
