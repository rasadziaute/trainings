using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Product: ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        public string Name { get; set; }
        public int Price { get; set; }
        public string Availability { get; set; }

        public Product(string name, int price, string availability)
        {
            Name = name;
            Price = price;
            Availability = availability;
        }

        public void SetAvailability(string availability)
        {
            Availability = availability;
            NotifyObservers();
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.update(Availability);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
    }
}
