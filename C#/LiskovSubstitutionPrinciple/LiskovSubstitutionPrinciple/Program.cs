using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liskov substitution principle states that child class objects should be able to replace parent class objects without compromising application integrity.
            //We created an abstract class with methods which are inherited by derived classes and overriding those methods. In this case, if we change type from derived class to a base class
            //child class overrides base class methods and application still works as expected.
            Account savingsAccount = new Savings(1, "Name", 2000);
            Account currentAccount = new Current(1, "Name", 2000);

            Console.WriteLine(savingsAccount.Withdraw(900));
            Console.WriteLine(currentAccount.Withdraw(900));

            Console.ReadLine();
        }
    }
}
