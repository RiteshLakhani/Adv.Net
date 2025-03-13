using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Solution
{
    internal class Number
    {
        public void checkEven()
        {
            try
            {
                Console.WriteLine("Enter Number: ");
                int number = int.Parse(Console.ReadLine());

                if(number % 2 != 0)
                {
                    throw new Exception("Entered number is not an even number");
                }

                Console.WriteLine("Enter Number is Even");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
