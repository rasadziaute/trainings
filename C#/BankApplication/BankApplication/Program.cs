using System;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Bank bank = new Bank();
            Console.WriteLine("Welocme to Bank Management System");
            while (true)
            {
                Console.WriteLine("How we can help you");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Show Account Information");
                Console.WriteLine("3. Deposit Amount");
                Console.WriteLine("4. WithDraw Amount");
                Console.WriteLine("5. Clear Screen");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter Account Type");
                        bank.CreateAccount();
                        break;

                    case "2":
                        Console.WriteLine("Enter Account Id");
                        bank.ShowAccountDetails();
                        break;

                    case "3":
                        Console.WriteLine("Enter Account Id");
                        bank.Deposit();
                        break;
                    case "4":
                        Console.WriteLine("Enter Account Id");
                        bank.Withdraw();
                        break;
                    case "5":
                        Console.Clear();
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
