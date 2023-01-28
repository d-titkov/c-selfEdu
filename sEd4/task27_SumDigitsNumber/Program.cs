// Task 27: Write a program that accepts a number as input 
// and returns the sum of the digits in the number.
// 452 -> 11    82 -> 10      9012 -> 12

Console.Write("Insert number: ");
int number = int.Parse(Console.ReadLine());
int result = number % 10;
while (number > 0)
{
    number = number / 10;
    result = result + number % 10;
}
Console.Write(" -> " + result);