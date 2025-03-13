using System;

namespace Lab_1_Solution
{
    internal class Student
    {
        int EnrollmentNo, Sem;
        String StudentName;
        double CPI, SPI;

        public Student()
        {
            Console.WriteLine("Please enter Enrollment Number : ");
            EnrollmentNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Student's Name : ");
            StudentName = Console.ReadLine();
            Console.WriteLine("Please enter Sem : ");
            Sem = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter CPI : ");
            CPI = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter SPI : ");
            SPI = double.Parse(Console.ReadLine());
        }

        public void DisplayStudentsDetails()
        {
            Console.WriteLine("Enrollment Number : {0}", EnrollmentNo);
            Console.WriteLine("Student's Name : {0}", StudentName);
            Console.WriteLine("Sem : {0}", Sem);
            Console.WriteLine("CPI : {0}", CPI);
            Console.WriteLine("SPI : {0}", SPI);
        }
    }
}
