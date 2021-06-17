using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethods
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get;
        }

        public string LastName
        {
            get;
        }

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
