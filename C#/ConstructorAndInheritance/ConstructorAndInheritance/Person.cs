using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAndInheritance
{
    public class Person
    {
        private double height;
        public Person(double _height)
        {
            height = _height;
        }
        public virtual void Greet()
        {
            Console.WriteLine("Person greets");
        }

        public virtual void Walk()
        {
            Console.WriteLine("Person is walking");
        }

        public void GetHeight()
        {
            Console.WriteLine($"Person is {height} high" );
        }
    }
}
