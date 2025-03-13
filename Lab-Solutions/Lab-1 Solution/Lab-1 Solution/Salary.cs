using System;


namespace Lab_1_Solution
{
    internal class Salary
    {
        double Basic, TA, DA, HRA, Gross_Salary;
        public Salary()
        {
            DA = 3000;
            HRA = 10000;
            Console.Write("Enter Basic Salary: ");
            this.Basic = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter TA: ");
            this.TA = Convert.ToDouble(Console.ReadLine());
            Gross_Salary = DA + TA + HRA + Basic;
        }

        public void Display()
        {
            Console.WriteLine("\nBasic salary : " + Basic);
            Console.WriteLine("DA : " + DA);
            Console.WriteLine("HRA : " + HRA);
            Console.WriteLine("Travelling allowence : " + TA);
            Console.WriteLine("Gross Salary : " + Gross_Salary);
        }
    }
}
