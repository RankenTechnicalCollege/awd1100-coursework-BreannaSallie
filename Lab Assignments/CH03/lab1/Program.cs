// See https://aka.ms/new-console-template for more information
const double KM_PER_MILE = 1.6;
Console.WriteLine("Enter distance in miles: ");
string ? input = Console.ReadLine();
if (double.TryParse(input, out double miles))
{
    double kilometers = miles * KM_PER_MILE;
    Console.WriteLine($"{miles} miles is {kilometers} kilometers.");
}
else
{
    Console.WriteLine("Invalid input. Please enter a numeric value.");
}