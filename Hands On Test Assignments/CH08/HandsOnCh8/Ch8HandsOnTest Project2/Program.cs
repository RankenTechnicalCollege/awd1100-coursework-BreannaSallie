using System;
using System.Collections.Generic;

namespace ShoppingCartCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> itemPrices = new List<decimal>();
            decimal price;
            int itemNumber = 1;

            Console.WriteLine("Enter item prices (enter 0 to finish):");

            while (true)
            {
                Console.Write($"{itemNumber:00}: ");
                string input = Console.ReadLine();

                // Try to parse the input
                if (!decimal.TryParse(input, out price))
                {
                    Console.WriteLine("INVALID PRICE");
                    continue;
                }

                // Check for termination input
                if (price == 0)
                {
                    break;
                }
                // Invalid price
                else if (price < 0)
                {
                    Console.WriteLine("INVALID PRICE");
                    continue;
                }

                // Valid price
                itemPrices.Add(price);
                itemNumber++;
            }

            Console.WriteLine("\n-------------------------------");

            int itemCount = itemPrices.Count;
            decimal subtotal = 0;

            foreach (decimal item in itemPrices)
            {
                subtotal += item;
            }

            decimal average = itemCount > 0 ? subtotal / itemCount : 0;
            decimal tax = subtotal * 0.08m;
            decimal total = subtotal + tax;

            // Output results
            Console.WriteLine($"Items Purchased:       {itemCount}");
            Console.WriteLine($"Average Item Price:    ${average:F2}");
            Console.WriteLine($"Subtotal:              ${subtotal:F2}");
            Console.WriteLine($"Tax:                   ${tax:F2}");
            Console.WriteLine($"Total:                 ${total:F2}");
        }
    }
}
