// See https://aka.ms/new-console-template for more information
using System.Transactions;
const double PERCENT_RAISE = 0.04; // 4% raise



Console.WriteLine("Enter the name of employee 1: ");
string name1= Console.ReadLine();
Console.WriteLine("Enter the salary of employee 1: ");
double salary1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the name of employee 2: ");
string name2 = Console.ReadLine();
Console.WriteLine("Enter the salary of employee 2: ");
double salary2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the name of employee 3: ");
string name3 = Console.ReadLine();
Console.WriteLine("Enter the salary of employee 3: ");
double salary3 = Convert.ToDouble(Console.ReadLine());

double salary1Year1 = salary1 + (salary1 * PERCENT_RAISE);
double salary1Year2 = salary1Year1 + (salary1Year1 * PERCENT_RAISE);  

double salary2Year1 = salary2 + (salary2 * PERCENT_RAISE);  
double salary2Year2 = salary2Year1 + (salary2Year1 * PERCENT_RAISE);    

double salary3Year1 = salary3 + (salary3 * PERCENT_RAISE);  
double salary3Year2 = salary3Year1 + (salary3Year1 * PERCENT_RAISE);





Console.WriteLine("\nProjected Salaries for the Next 2 Years:");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine($"{"Employee",-15}{"2020",-10}{"2021",-10}"); 
Console.WriteLine("-------------------------------------------------");
Console.WriteLine($"{name1,-15}{salary1Year1,-10:C}{salary1Year2,-10:C}");  
Console.WriteLine($"{name2,-15}{salary1Year1,-10:C}{salary2Year2,-10:C}");
Console.WriteLine($"{name3,-15}{salary1Year1,-10:C}{salary3Year2,-10:C}");

