// Write a program that takes three numbers as 
//input and outputs the maximum of these numbers.

Console.Write("Insert first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Insert second number: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Insert third number: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine(max);