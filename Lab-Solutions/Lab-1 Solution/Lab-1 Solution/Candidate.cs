using System;

namespace Lab_1_Solution
{
    internal class Candidate
    {
        private int Id, Age;
        private String Name;
        private double Weight, Height;

        public void GetCandidateDetails() 
        {
            Console.Write("Enter Id: ");
            this.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name : ");
            this.Name = Console.ReadLine();

            Console.Write("Enter Age : ");
            this.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Weight : ");
            this.Weight = double.Parse(Console.ReadLine());

            Console.Write("Enter Height : ");
            this.Height = double.Parse(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("ID : " + this.Id);
            Console.WriteLine("Name : " + this.Name);
            Console.WriteLine("Age : " + this.Age);
            Console.WriteLine("Weight : " + this.Weight);
            Console.WriteLine("Height : " + this.Height);
        }
    }
}
