using System;

namespace Lab_2_Solution
{
    internal class ZeroException
    {
        public void DivideByZero()
        {
            try
            {
                Console.WriteLine("Enter the base number: ");
                int baseNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the divisor: ");
                int divisor = int.Parse(Console.ReadLine());

                int result = baseNumber / divisor;
                Console.WriteLine($"The result of {baseNumber} divided by {divisor} is {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception caught: Division by zero is not allowed.");
            }
        }
    }
}
