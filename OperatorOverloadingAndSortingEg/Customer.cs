
namespace OperatorOverloadingAndSortingEg
{
    public class Customer
    { 
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Customer(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Override ToString for better display
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }       

    }
}

