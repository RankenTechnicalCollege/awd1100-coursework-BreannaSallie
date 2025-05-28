// See https://aka.ms/new-console-template for more information
Console.Write("Enter score 1: ");
double score1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter score 2: ");
double score2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter score 3: ");   
double score3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter score 4: ");
double score4 = Convert.ToDouble(Console.ReadLine());
double average = (score1 + score2 + score3 + score4) / 4;
Console.WriteLine($"The average score is: {average}");