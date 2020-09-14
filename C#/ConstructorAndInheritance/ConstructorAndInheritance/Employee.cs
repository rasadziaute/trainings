using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAndInheritance
{
    class Employee : Person, IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public double Height { get; set; }

        private Employee(double height):base(height) {
            Console.WriteLine("Private constructor");
         }

        private Employee(string name, double height): base(height)
        {
            Console.WriteLine($"Private constructor of employee {name}");
        }

        public Employee(int id, string name, string department, double salary, double height): base(height)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
            Height = height;

            Console.WriteLine($"Added employee with details: Name {name}, Department {department}, Salary {salary}");
        }

        public override void Greet()
        {
            Console.WriteLine($"Employee {Name} says Hi");
        }

        public override void Walk()
        {
            Console.WriteLine($"Employee {Name} walks");
        }

       

    }
}
