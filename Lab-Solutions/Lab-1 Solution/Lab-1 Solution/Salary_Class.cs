using System;

namespace Lab_1_Solution
{
    interface IGross
    {
        Double Gross_Salary();
    }

    internal class Salary_Class
    {
        public string Name;
        public double Basic_Salary;

        public void Basic_Sal()
        {
            Console.Write("Please enter Name: ");
            this.Name = Console.ReadLine();
            Console.Write("Please enter Basic Salary: ");
            this.Basic_Salary = Convert.ToDouble(Console.ReadLine());
        }
    }

    class Salary_Employee : Salary_Class, IGross
    {
        private double HRA, TA, DA;

        public Salary_Employee()
        {
            Basic_Sal();
            Console.Write("Please Enter TA: ");
            TA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter DA: ");
            DA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please Enter HRA: ");
            HRA = Convert.ToDouble(Console.ReadLine());
        }

        public Double Gross_Salary()
        {
            return (Basic_Salary + HRA + TA + DA);
        }

        public void Display_Salary()
        {
            Console.WriteLine("Name: {0}, Gross Salary : {1}", Name, Gross_Salary());
        }
    }
}
