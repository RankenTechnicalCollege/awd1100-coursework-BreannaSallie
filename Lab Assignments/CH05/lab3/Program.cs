using System;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            decimal danielleSales = 0, edwardSales = 0, francisSales = 0;

            while (true)
            {
                Console.Write("Who made the sale? (d/e/f or z to quit): ");
                string initial = Console.ReadLine().Trim().ToLower();

                if (initial == "z") break;
                if (initial != "d" && initial != "e" && initial != "f")
                {
                    Console.WriteLine("Invalid initial");
                    continue;
                }

                Console.Write("How much was the sale? ");
                if (!decimal.TryParse(Console.ReadLine(), out var amount))
                {
                    Console.WriteLine("Invalid amount");
                    continue;
                }

                if (initial == "d") danielleSales += amount;
                else if (initial == "e") edwardSales += amount;
                else francisSales += amount;
            }

            Console.WriteLine($"\nDanielle Sales: {danielleSales:C}");
            Console.WriteLine($"Edward Sales: {edwardSales:C}");
            Console.WriteLine($"Francis Sales: {francisSales:C}");
            var grand = danielleSales + edwardSales + francisSales;
            Console.WriteLine($"\nGrand Total: {grand:C}");

            string top = (danielleSales >= edwardSales && danielleSales >= francisSales) ? "Danielle"
                       : (edwardSales >= francisSales) ? "Edward" : "Francis";
            Console.WriteLine($"{top} has the most sales");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}