using System;

namespace PropertiesAndMethods
{
    public class ShoppingList
    {
        public ShoppingList()
        {
            Console.WriteLine("Initializing ShoppingList");
        }

        public decimal Total { get; private set; } = 0M;

        public void AddProduct(
            string productName,
            decimal unitPrice,
            decimal quantity = 1M,
            decimal vatPercent = 19M)
        {
            decimal productTotal = unitPrice * quantity * (1 + vatPercent / 100);
            Console.WriteLine($"{productName, -15} {unitPrice, 6} {quantity, 6} {vatPercent, 4} {productTotal, 6}");
            Total += productTotal;
        }
    }
}
