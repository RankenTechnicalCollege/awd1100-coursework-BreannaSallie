// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your full name:");
string name = Console.ReadLine();

Console.WriteLine("Enter your street address:");
string streetAddress = Console.ReadLine();

Console.WriteLine("Enter youur city:");
string city = Console.ReadLine();

Console.WriteLine("Enter your state:");
string state = Console.ReadLine();

Console.WriteLine("Enter your ZIP code:");
string ZIPcode = Console.ReadLine();

Console.WriteLine("Enter the quantity of tshirts ordered:");
int quantity = Convert.ToInt32(Console.ReadLine());

double pricePerShirt = 14.99;
double totalCost = quantity * pricePerShirt;
double salesTax = totalCost * 0.08;
double amountDue = totalCost + salesTax;

Console.WriteLine("\n==== ORDER SUMMARY ====");
Console.WriteLine("Customer;" + name);
Console.WriteLine("Address: " + streetAddress);
Console.WriteLine("City: " + city);
Console.WriteLine("State: " + state);
Console.WriteLine("ZIP Code: " + ZIPcode);  
Console.WriteLine("T-shirts Ordered: " + quantity);
Console.WriteLine("Price per T-shirt: $" + pricePerShirt.ToString("F2"));
Console.WriteLine("Total Cost: $" + totalCost.ToString("F2"));
Console.WriteLine("Sales Tax (8%): $" + salesTax.ToString("F2"));
Console.WriteLine("Amount Due: $" + amountDue.ToString("F2"));


