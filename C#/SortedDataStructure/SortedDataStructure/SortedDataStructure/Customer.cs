using System;
using System.Collections.Generic;
using System.Text;

namespace SortedDataStructure
{
    class Customer : IEquatable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public bool Equals(Customer other)
        {
            if (other == null)
            {
                return false;
            }
            else
            {
                return (Name.Equals(other.Name));
            }
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
