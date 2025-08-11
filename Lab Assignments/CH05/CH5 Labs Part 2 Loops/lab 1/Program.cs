using System;

var stats = new ScoreStats();

while (true)
{
    Console.Write("Please enter a test score: ");
    var input = Console.ReadLine();

    if (!double.TryParse(input, out var value))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        continue;
    }

    if (value == 999) break;

    if (!stats.TryAdd(value, out var error))
        Console.WriteLine(error);
}

if (stats.Count > 0)
{
    Console.WriteLine($"\nNumber of scores: {stats.Count}");
    Console.WriteLine($"Sum of test scores: {stats.Sum}");
    Console.WriteLine($"Average test score: {stats.Average}");
    Console.WriteLine($"Lowest test score: {stats.Min}");
    Console.WriteLine($"Highest test score: {stats.Max}");
}
else
{
    Console.WriteLine("\nNo valid scores entered.");
}

Console.WriteLine("Press any key to continue . . .");
Console.ReadKey();