using System;

namespace Lab_1_Solution
{
    internal class Rectangle
    {
        double length, breadth;

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double CalculateArea()
        {

            return this.length * this.breadth;
        }

    }
}
