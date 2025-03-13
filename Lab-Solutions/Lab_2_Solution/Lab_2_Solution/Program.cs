using System;
using Lab_2_Solution;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter 1 For Divide by Zero Exception");
        Console.WriteLine("Enter 2 For IndexOutOfRange Exception");
        Console.WriteLine("Enter 3 For Abstract class Sum");
        Console.WriteLine("Enter 4 For Interface Calculate");
        Console.WriteLine("Enter 5 For String class");
        Console.WriteLine("Enter 6 For Lower-case to Upper cash & Upper-case to Lower-case");
        Console.WriteLine("Enter 7 For Shape Interface");
        Console.WriteLine("Enter 8 For throw exception if number is not even");
        Console.WriteLine("Enter 9 For Find Longest word from String");
        Console.WriteLine("Enter 10 For Chnaged the case of entered character");

        Console.WriteLine("\n");
        Console.Write("Enter Your choice: ");
        int ch = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        switch (ch)
        {
            case 1:
                ZeroException ze = new ZeroException();
                ze.DivideByZero();
                break;
            case 2:
                indexOutOfRange ie = new indexOutOfRange();
                ie.ReadNumber();
                break;
            case 3:

                SumandCal sc = new SumandCal();

                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());
                // Call sumOfTwo method
                int sumOfTwo = sc.sumOfTwo(num1, num2);
                Console.WriteLine($"Sum of {num1} and {num2} is: {sumOfTwo}");

                Console.Write("Enter third number: ");
                int num3 = int.Parse(Console.ReadLine());
                // Call SumOfThree method
                int sumOfThree = sc.sumOfThree(num1, num2, num3);
                Console.WriteLine($"Sum of {num1}, {num2}, and {num3} is: {sumOfThree}");
                break;
            case 4:
                Interface ic = new Interface();

                Console.Write("Enter first number: ");
                int num4 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int num5 = int.Parse(Console.ReadLine());

                int additionResult = ic.Add(num4, num5);
                Console.WriteLine($"Addition of {num4} and {num5} is: {additionResult}");

                int subtractionResult = ic.Sub(num4, num5);
                Console.WriteLine($"Subtraction of {num4} and {num5} is: {subtractionResult}");
                break;
            case 5:
                String_Methods s = new String_Methods();
                break;
            case 6:
                UpperLower ul = new UpperLower();

                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();

                // Call convertCase method
                string converted = ul.ConvertCase(input);
                Console.WriteLine("Converted string:");
                Console.WriteLine(converted);
                break;
            case 7:
                Shape shapeCalculator = new Shape();

                Console.Write("Enter the radius of the circle: ");
                double radius = double.Parse(Console.ReadLine());
                double circleArea = shapeCalculator.Circle(radius);
                Console.WriteLine($"Area of Circle with radius {radius}: {circleArea}");

                Console.Write("Enter the base length of the triangle: ");
                double baseLength = double.Parse(Console.ReadLine());
                Console.Write("Enter the height of the triangle: ");
                double height = double.Parse(Console.ReadLine());
                double triangleArea = shapeCalculator.Triangle(baseLength, height);
                Console.WriteLine($"Area of Triangle with base {baseLength} and height {height}: {triangleArea}");

                Console.Write("Enter the side length of the square: ");
                double sideLength = double.Parse(Console.ReadLine());
                double squareArea = shapeCalculator.Square(sideLength);
                Console.WriteLine($"Area of Square with side length {sideLength}: {squareArea}");
                break;
            case 8:
                Number n = new Number();
                n.checkEven();
                break;
            case 9:
                longest lg = new longest();
                string str = "Hii I am Ritesh. Pursuing My B.Tech in Darshan University";
                string longestWord = lg.FindLongestWord(str);
                Console.WriteLine("lONGEST WORD IN STRING IS : " + longestWord);
                break;
            case 10:
                ChangeCase cc = new ChangeCase();

                Console.WriteLine("Enter a character:");
                char inputChar = Console.ReadKey().KeyChar;
                char convertedChar = cc.ConvertCase(inputChar);

                Console.WriteLine($"\nConverted character: {convertedChar}");

                break;
            default:
                break;
        }
    }
}