using System;
using Lab_3_Solution;
using Microsoft.CSharp.RuntimeBinder;
using static Lab_3_Solution.Program7;

public class Program

{
    public static void Main(String[]args)
    {
        Console.WriteLine("Enter 1 For Method Overloading");
        Console.WriteLine("Enter 2 For Method Overloading For Area of Square and Rectangle");
        Console.WriteLine("Enter 3 For Method Overriding");
        Console.WriteLine("Enter 4 For Factorail with Delegate");
        Console.WriteLine("Enter 5 For Method Overrides with hospital , apollo etc");
        Console.WriteLine("Enter 6 For Area of Squar , Reactangle, Circle with overrides");
        Console.WriteLine("Enter 7 For Overriding traffic lights");
        Console.WriteLine("Enter 8 For Genric Delegate Cal");

        Console.WriteLine("\n");
        Console.Write("Enter Your choice: ");
        int ch = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        switch(ch)
        {
            case 1:
                Program1 p1 = new Program1();

                int Result = p1.Add(5, 3);
                Console.WriteLine(Result);

                float result = p1.Add(2.5f, 3.5f);
                Console.WriteLine(result);

                break;

            case 2:
                Program2 program = new Program2();

                int squareArea = program.Area(5);
                Console.WriteLine("Area of square with side 5 is: " + squareArea);

                int rectangleArea = program.Area(5, 10);
                Console.WriteLine("Area of rectangle with length 5 and breadth 10 is: " + rectangleArea);
                break;

            case 3:
                Program3.RBI rbi  = new Program3.RBI();
                Program3.HDFC hdfc  = new Program3.HDFC();
                Program3.ICICI icici = new Program3.ICICI();
                Program3.SBI sbi = new Program3.SBI();

                rbi.CalculateIntrest();
                hdfc.CalculateIntrest();
                icici.CalculateIntrest();
                sbi.CalculateIntrest();

                break;
            case 4:
                Program4.FactorialDelegate factorialdelegate = Program4.Cal;

                for(int i =1;i<=5;i++)
                {
                    int result1 = factorialdelegate(i);
                    Console.WriteLine(result1);
                }
                break;
            case 5:
                Program5.Hospital hospital = new Program5.Hospital();
                Program5.Hospital apollo = new Program5.Apollo();
                Program5.Hospital wockhardt = new Program5.Wockhardt();
                Program5.Hospital gokul_superspeciality = new Program5.Gokul_Superspeciality();

                hospital.HospitalDetails();
                apollo.HospitalDetails();
                wockhardt.HospitalDetails();
                gokul_superspeciality.HospitalDetails();
                break;
            case 6:
                Program6 cal = new Program6();

                double squareAreas = cal.CalculateArea(5);
                Console.WriteLine($"Area of Square: {squareAreas}");

                double rectangleAreas = cal.CalculateArea(5, 10);
                Console.WriteLine($"Area of Rectangle: {rectangleAreas}");

                double circleArea = cal.CalculateArea(7.0);
                Console.WriteLine($"Area of Circle: {circleArea}");

                break;
            case 7:
                Program7.TrafficDel del1 = TrafficSingal.Red;
                Program7.TrafficDel del2 = TrafficSingal.Yellow;
                Program7.TrafficDel del3 = TrafficSingal.Green;

                del1();
                del2();
                del3();

                break;

        case 8:
                CalculatorDelegate<int> operation;

                operation = Cal.Add;
                Console.WriteLine($"10 + 5 = {operation(10,5)}");

                operation = Cal.Subtract;
                Console.WriteLine($"10 - 5 = {operation(10, 5)}");

                operation = Cal.Multiply;
                Console.WriteLine($"10 * 5 = {operation(10, 5)}");

                operation = Cal.Divide;
                Console.WriteLine($"10 / 5 = {operation(10, 5)}");

                break;
        }
    }
}