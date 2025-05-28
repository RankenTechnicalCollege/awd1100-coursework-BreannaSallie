// See https://aka.ms/new-console-template for more information
using System;
const double DAILY_RATE = 100.0;
const double MILE_RATE = 0.50;

Console.Write("Enter the number of days rented: ");
int days = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of miles driven: ");
double miles = Convert.ToDouble(Console.ReadLine());

double totalCost = (days * DAILY_RATE) + (miles * MILE_RATE);
Console.WriteLine($"Total cost of the car rental: {totalCost:C}");

