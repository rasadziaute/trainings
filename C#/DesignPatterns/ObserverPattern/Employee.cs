using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Employee: IObserver
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UpdateMessage { get; set; }

        public Employee(string firstName, string lastName, ISubject subject)
        {
            FirstName = firstName;
            LastName = lastName;
            subject.RegisterObserver(this);
        }
        public void update(string availability)
        {
            UpdateMessage = $"{FirstName}, notification of product availability: {availability}";
        }
    }
}
