using System;

namespace Lab_1_Solution
{
    internal class Staff
    {
        public string Name { get; private set; }
        public string Department { get; private set; }
        public string Designation { get; private set; }
        public int Experience { get; private set; }
        public double Salary { get; private set; }

        public Staff(string name, string department, string designation, int experience, double salary)
        {
            Name = name;
            Department = department;
            Designation = designation;
            Experience = experience;
            Salary = salary;
        }
    }
}
