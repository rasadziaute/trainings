using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAndInheritance
{
    class Customer : Person, ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int OrderId { get; set; }

        public double Height { get; set; }

        public Customer(int id, string name, string address, int orderId, double height): base(height)
        {
            Id = id;
            Name = name;
            Address = address;
            OrderId = orderId;
        }

        public override void Greet()
        {
            Console.WriteLine($"Customer {Name} says Hi");
        }

        public override void Walk()
        {
            Console.WriteLine($"Customer {Name} walks");
        }

    }
}
