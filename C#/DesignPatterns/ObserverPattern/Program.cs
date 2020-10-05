using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var catProduct = new Product("Cat sweater", 200, "In Stock");

            var customer1 = new Customer("Customer1", catProduct);
            var customer2 = new Customer("Customer2", catProduct);
            var employee = new Employee("Employee Name", "Employee Last Name", catProduct);

            catProduct.SetAvailability("Out of Stock");

            Console.WriteLine(customer1.UpdateMessage);
            Console.WriteLine(customer2.UpdateMessage);
            Console.WriteLine(employee.UpdateMessage);

            catProduct.RemoveObserver(customer2);

            catProduct.SetAvailability("In Stock");

            Console.WriteLine(customer1.UpdateMessage);
            Console.WriteLine(customer2.UpdateMessage);
            Console.WriteLine(employee.UpdateMessage);
        }
    }
}
