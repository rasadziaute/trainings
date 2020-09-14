using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAndInheritance
{
    interface ICustomer
    {
        int Id { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        int OrderId { get; set; }
    }
}
