using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethods
{
    public class Person
    {
        private string firstName;
        
        public string FirstName
        {
            get
            {
                /* executed when someone tries to read FirstName */
                Console.WriteLine("Executing FirstName.get");
                if (string.IsNullOrEmpty(firstName))
                {
                    firstName = "Test FirstName";
                }

                return firstName;
            }
            private set
            {
                /* executed when someone tries to write FirstName */
                Console.WriteLine("Executing FirstName.set");

                if (string.IsNullOrEmpty(value))
                {
                    value = string.Empty;
                }

                firstName = value;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Hello, my name is {FirstName}");
        }
    }
}
