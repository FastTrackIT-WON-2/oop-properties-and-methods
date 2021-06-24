using System;

namespace PropertiesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person p = new Person("FirstName", "LastName");
            // p.Print();

            /*
            CollectionOfIntegers c = new CollectionOfIntegers(new[] { 1, 2, 3, 4 });
            int max = c.Max();
            Console.WriteLine(max);
            Console.WriteLine($"{c[0]}");
            */

            /*
            MatrixHelper m = new MatrixHelper(new[,]
            {
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9},
                { 10, 11, 12}
            });

            m.PrintMainDiagonal();
            Console.WriteLine($"{m[0, 0]}");
            */

            /*
            Address a = new Address();
            a.City = "Oradea";
            a.Street = "Republicii";
            a.PostalCode = "123";

            string city = a["City"];

            Console.WriteLine($"{city}");
            */

            /*
            ConsoleHelper.PrintMessage("abc");
            ConsoleHelper.PrintMessage("def", "test");
            ConsoleHelper.PrintMessage("xyz", 3);
            */

            /*
            Iterator i = new Iterator(new[] { 1, 2, 3, 4, 5, 6 });
            i.Iterate();
            
             */

            /*
            ShoppingList list = new ShoppingList();
            list.AddProduct("Paine", 5);
            list.AddProduct("Apa", 3, quantity: 6);
            list.AddProduct("Other stuff", 10, quantity: 1, vatPercent: 5);

            Console.WriteLine($"Total: {list.Total}");
            */

            ApplicationLogger.Instance.WriteLog("Message 1");
            ApplicationLogger.Instance.WriteLog("Message 2");

            //Person p2 = new Person("John", "Doe");
            //p2.Print();

        }
    }
}
