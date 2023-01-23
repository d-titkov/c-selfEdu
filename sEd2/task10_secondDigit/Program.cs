// Write a program that accepts a three-digit number as input.
//and the output shows the second digit of this number.

Console.Write("Enter number from 100 to 999: ");
int num = int.Parse(Console.ReadLine());

int result = num / 10 % 10;

Console.WriteLine($"{result} - the second digit of this number");