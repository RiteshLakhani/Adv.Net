using System;

namespace Lab_2_Solution
{
    internal class indexOutOfRange
    {
        public void ReadNumber()
        {
            int[] num = new int[5];
            int count = 0;

            try
            {
                while (true)
                {
                    Console.WriteLine("Enter a number: ");
                    int nums = int.Parse(Console.ReadLine());

                    num[count] = nums;
                    count++;

                    Console.Write("Enterd Number: ");
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(num[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nException caught: You have entered more than 5 numbers.");
            }
        }
    }
}
