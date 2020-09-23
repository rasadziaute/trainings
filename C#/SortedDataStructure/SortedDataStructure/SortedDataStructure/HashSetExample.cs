using System;
using System.Collections.Generic;
using System.Text;

namespace SortedDataStructure
{
    public class HashSetExample
    {
        public void RunHashSetExample()
        {
            var customer = new HashSet<Customer>();

            var customer1 = new Customer(1, "name1");
            var customer2 = new Customer(2, "name2");
            var customer3 = new Customer(2, "name2");

            Console.WriteLine("customer.Add(customer1): {0}", customer.Add(customer1));
            Console.WriteLine("customer.Add(customer2): {0}", customer.Add(customer2));
            Console.WriteLine("customer.Add(customer3): {0}", customer.Add(customer3));
        }


    }
}
