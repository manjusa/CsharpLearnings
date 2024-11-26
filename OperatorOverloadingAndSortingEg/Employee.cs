using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAndSortingEg
{
    public class Employee : IComparable<Employee>
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }

        // Constructor
        public Employee(string name, int age, string role)
        {
            Name = name;
            Age = age;
            Role = role;
        }

        // Override ToString for better display
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Role: {Role}";
        }

        public int CompareTo(Employee other)
        {
            if (other == null) return 1; // Current instance is greater if other is null
            return string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }

    }
}

