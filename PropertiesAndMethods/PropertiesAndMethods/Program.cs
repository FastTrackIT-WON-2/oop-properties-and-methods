using System;

namespace PropertiesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.FirstName);
            p.Print();
        }
    }
}
