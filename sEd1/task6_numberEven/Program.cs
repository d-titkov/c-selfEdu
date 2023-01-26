// Write a program that takes a number as input and outputs whether
//the number is even (whether it is divisible by two without a remainder).

Console.Write("Insert any number: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0) Console.WriteLine("YES, the number is even");
else Console.WriteLine("NO, the number isn`t even");