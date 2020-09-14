using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAndInheritance
{
    interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        string Department { get; set; }
        double Salary { get; set; }
    }
}
