using System;


namespace Lab_1_Solution
{
    internal class Bank_Account
    {
        int Account_No;
        String Email, User_Name, Account_Type;
        double Account_Balance;

        public void GetAccountDetails()
        {
            Console.Write("Enter Account No: ");
            this.Account_No = int.Parse(Console.ReadLine());

            Console.Write("Enter User Name: ");
            this.User_Name = Console.ReadLine();

            Console.Write("Enter Account Type: ");
            this.Account_Type = Console.ReadLine();

            Console.Write("Enter Email: ");
            this.Email = Console.ReadLine();

            Console.Write("Enter Account Balance: ");
            this.Account_Balance = double.Parse(Console.ReadLine());
        }

        public void DisplayAccountDetails() 
        {
            Console.WriteLine("Account_No: " + this.Account_No);
            Console.WriteLine("User_Name: " + this.User_Name);
            Console.WriteLine("Account_Type: " + this.Account_Type);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Account_Balance: " + this.Account_Balance);
        }
    }
}
