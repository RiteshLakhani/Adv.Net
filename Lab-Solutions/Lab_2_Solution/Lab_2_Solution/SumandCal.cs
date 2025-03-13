using System;


namespace Lab_2_Solution
{
    public abstract class Sum
    {
        public abstract int sumOfTwo(int a, int b);
        public abstract int sumOfThree(int a, int b, int c);
    }
    internal class SumandCal : Sum
    {
        public override int sumOfTwo(int a, int b)
        {
            return a + b;
        }

        public override int sumOfThree(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
