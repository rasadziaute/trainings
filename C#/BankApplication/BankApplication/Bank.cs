using BankApplication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApplication
{
    class Bank
    {
        public string[] custName = new string[3];
        public string[] custID = new string[3];
        public AccountType[] accountType = new AccountType[3];
        public string[] mydateOfBirth = new string[3];
        public double[] myBalance = new double[3];
        public string id;// hold the id generated from idGenerator class and add string
        public int idnum = 0;// index number for account ID;
                             // we will use below variables in Create_Account method

        public bool val = true;
        public bool depositval = true;

        IdGenerator id1 = new IdGenerator();
        DateofBirth dateOfBirth = new DateofBirth();
        Savings savings = new Savings();
        Current current = new Current();


        private void GetAccount(string Id)
        {
            custID[idnum] = Id;
            idnum++;
        }

        public void CreateAccount()
        {
            
            Console.WriteLine("1. Savings \n2. Current");
            string input = Console.ReadLine();
            if (input == "1")
            {
                accountType[idnum] = AccountType.Savings;
            }
            else
            {
                accountType[idnum] = AccountType.Current;
            }

            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            custName[idnum] = name;

            while (dateOfBirth.DateValidation() == false)
            {
                Console.WriteLine("Enter Date of Birth");
                int d = Convert.ToInt32(Console.ReadLine());
                int m = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                dateOfBirth.AssignValue(d, m, y);
                if (dateOfBirth.DateValidation())
                {
                    mydateOfBirth[idnum] = dateOfBirth.DisplayDate();
                }
                else
                {
                    Console.WriteLine("Date is not correct.");
                }
            }

            if (accountType[idnum] == AccountType.Savings)
            {
                Console.WriteLine("Enter the balance");
                double balance = Convert.ToDouble(Console.ReadLine());
                myBalance[idnum] = balance;

                Console.WriteLine("Savings Account Created Successfully");

                id = "EMI" + id1.GenerateID();
                Console.WriteLine($" Your Account Number is  {id}");
                GetAccount(id);
            }
            else
            {
                while (depositval == true)
                {
                    Console.WriteLine("Enter the balance");
                    double balance = Convert.ToDouble(Console.ReadLine());
                    if (balance < current.minBalance)
                    {
                        Console.WriteLine($"Current Account MinBalance should be {current.minBalance}");
                        depositval = true;
                    }

                    else
                    {
                        myBalance[idnum] = balance;
                        depositval = false;

                    }
                }

                Console.WriteLine("Current Account Created Successfully");
                id = "Current" + id1.GenerateID();
                Console.WriteLine($"Your Account id is {id}");
                GetAccount(id);
            }

        }


        public void ShowAccountDetails()
        {
            int indexnum;
            string accountID = Console.ReadLine();
            if (custID.Contains(accountID))
            {
                indexnum = Array.IndexOf(custID, accountID);
                Console.WriteLine($"Name is {custName[indexnum]}");
                Console.WriteLine($" ID : {custID[indexnum]}");
                Console.WriteLine($"Acc Type {accountType[indexnum]}");
                Console.WriteLine($" Balance is {myBalance[indexnum]}");
                Console.WriteLine($"dateOfBirth is {mydateOfBirth[indexnum]}");

            }

            else
            {
                Console.WriteLine("Entered Incorrect Account Info");
            }
        }

        public void Deposit()
        {
            int indexNum;
            string inID = Console.ReadLine();
            do
            {
                if (custID.Contains(inID))
                {
                    indexNum = Array.IndexOf(custID, inID);
                    Console.WriteLine($"Your Balance is {myBalance[indexNum]}");
                    Console.WriteLine("Enter the amount you want to deposit");
                    double depositamount = Convert.ToDouble(Console.ReadLine());
                    if (accountType[indexNum] == AccountType.Savings)
                    {
                        savings.balance = myBalance[indexNum];
                        savings.Deposit(depositamount);
                        myBalance[indexNum] = savings.balance;
                    }


                    else if (accountType[indexNum] == AccountType.Current)
                    {
                        current.balance = myBalance[indexNum];
                        current.Deposit(depositamount);
                        myBalance[indexNum] = current.balance;
                    }

                    Console.WriteLine($"Your Balance is {myBalance[indexNum]}");
                }
                else
                {
                    Console.WriteLine("Enter Correct Account id");
                    inID = Console.ReadLine();
                }
            } while (custID.Contains(inID) == false);
        }

        public void Withdraw()
        {
            int indexNum;
            string inID = Console.ReadLine();
            do
            {
                if (custID.Contains(inID))
                {
                    indexNum = Array.IndexOf(custID, inID);
                    Console.WriteLine($"Your Balance is {myBalance[indexNum]}");
                    Console.WriteLine("Enter the amount you want to withdraw");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    if (accountType[indexNum] == AccountType.Savings)
                    {
                        savings.balance = myBalance[indexNum];
                        Console.WriteLine(savings.WithDraw(withdrawAmount));
                        myBalance[indexNum] = savings.balance;
                    }
                    else if (accountType[indexNum] == AccountType.Current)
                    {
                        current.balance = myBalance[indexNum];
                        Console.WriteLine(current.WithDraw(withdrawAmount));
                        myBalance[indexNum] = current.balance;
                    }

                    Console.WriteLine($"Your Balance is {myBalance[indexNum]}");
                }
                else
                {
                    Console.WriteLine("Enter Correct Account id");
                    inID = Console.ReadLine();
                }
            } while (custID.Contains(inID) == false);
        }
    }
}
