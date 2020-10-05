using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Customer : IObserver
    {
        public string Name { get; set; }

        public string  UpdateMessage { get; set; }

        public Customer(string name, ISubject subject)
        {
            Name = name;
            subject.RegisterObserver(this);
        }
        public void update(string availability)
        {
            UpdateMessage = $"Hi, {Name}, Product availability is {availability}";
        }
    }
}
