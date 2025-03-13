using System;
using Lab_1_Solution;

namespace Lab_1_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Program to run(1-10) or 0 for exit");
                Console.WriteLine("1. Candidate");
                Console.WriteLine("2. Staff");
                Console.WriteLine("3. Bank_Account");
                Console.WriteLine("4. Student");
                Console.WriteLine("5. Rectangle");
                Console.WriteLine("6. Account_Details");
                Console.WriteLine("7. Salary");
                Console.WriteLine("8. Distance");
                Console.WriteLine("9. Furniture");
                Console.WriteLine("10. Salary Class");

                Console.WriteLine("\n");
                Console.Write("Enter Your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                if (choice == 0)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Candidate candidate = new Candidate();
                        candidate.GetCandidateDetails();
                        Console.WriteLine("\n----------Candidate Details-----------\n");
                        candidate.DisplayCandidateDetails();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Staff[] staffArray = new Staff[5];
                        for (int j = 0; j < 5; j++)
                        {
                            Console.WriteLine($"\nEnter details for staff member {j + 1}:");

                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Department: ");
                            string department = Console.ReadLine();
                            Console.Write("Designation: ");
                            string designation = Console.ReadLine();
                            Console.Write("Experience (in years): ");
                            int experience = int.Parse(Console.ReadLine());
                            Console.Write("Salary: ");
                            double salary = double.Parse(Console.ReadLine());

                            staffArray[j] = new Staff(name, department, designation, experience, salary);
                        }

                        Console.WriteLine("\n----------Staff Details-----------\n");
                        foreach (var staff in staffArray)
                        {
                            if (staff.Designation.Equals("HOD", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"Name: {staff.Name}, Salary: {staff.Salary}");
                            }
                        }
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Bank_Account b = new Bank_Account();
                        b.GetAccountDetails();
                        Console.WriteLine("\n----------Bank Account Details-----------\n");
                        b.DisplayAccountDetails();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Student student = new Student();
                        Console.WriteLine("\n----------Student Details-----------\n");
                        student.DisplayStudentsDetails();
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        Console.Write("Enter length: ");
                        double length = double.Parse(Console.ReadLine());

                        Console.Write("Enter breadth: ");
                        double breadth = double.Parse(Console.ReadLine());

                        Rectangle obj = new Rectangle(length, breadth);
                        Console.WriteLine("\n----------Area Details-----------\n");
                        Console.WriteLine("Area of Rectangle is: " + obj.CalculateArea().ToString());
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        Interest i = new Interest();
                        Console.WriteLine("\n----------Simple Interest Details-----------\n");
                        i.DisplayInterest();
                        Console.WriteLine("\n");
                        break;
                    case 7:
                        Salary s = new Salary();
                        Console.WriteLine("\n----------Salary Details-----------\n");
                        s.Display();
                        Console.WriteLine("\n");
                        break;
                    case 8:
                        Console.WriteLine("Please enter distance 1: ");
                        double dist1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter distance 2: ");
                        double dist2 = Convert.ToDouble(Console.ReadLine());
                        Distance d = new Distance(dist1, dist2);
                        d.Sum();
                        Console.WriteLine("\n----------Distance Details-----------\n");
                        d.Display();
                        Console.WriteLine("\n");
                        break;
                    case 9:
                        Table objTable = new Table();
                        objTable.GetData();
                        Console.WriteLine("\n----------Furniture Details-----------\n");
                        objTable.ShowData();
                        Console.WriteLine("\n");
                        break;
                    case 10:
                        Salary_Employee s1 = new Salary_Employee();
                        Console.WriteLine("\n----------Interface Solution -----------\n");
                        s1.Display_Salary();
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.WriteLine("Enter Valid Number for Output Between 1 to 10 !!!!!!");
                        break;
                }
            }
        }
    }
}
