// Write a program that takes two numbers as input 
//and outputs which number is greater and which is less.

Console.Write("Insert first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Insert second number: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2) Console.WriteLine($"max = {num1}");
if (num2 > num1) Console.WriteLine($"max = {num2}");