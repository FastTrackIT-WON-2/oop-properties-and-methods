using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethods
{
    public class Person
    {
        public Person() 
            : this(string.Empty, string.Empty)
        {
            Console.WriteLine("Called Person parameterless ctor");
        }

        public Person(string firstName, string lastName)
        {
            Console.WriteLine("Called Person ctor with 2 params");

            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }

        public string LastName { get; } 

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public void Print()
        {
            Console.WriteLine($"Hello, my name is {FullName}");
        }
    }
}
