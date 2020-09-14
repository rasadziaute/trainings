using System;

namespace ConstructorAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting error, you can't invoke private constructor
            //var privateEmployee = new Employee(1.74);

            //You can have two private constructors in a class
            //var privateEmployeeName = new Employee("Rasa", 1.74);

            //We can have one private and one public constructor, but you will only be able to invoke public constructor
            var publicEmployee = new Employee(1, "Rasa", "Technology", 12.20, 1.74);

            publicEmployee.Walk();
            publicEmployee.GetHeight();

            var customer = new Customer(1, "Sam", "Vilniaus str", 2, 1.67);

            //showing inheritance, polymorphism and interfaces
            customer.Walk();
            customer.GetHeight();



            Console.ReadKey();
        }
    }
}
