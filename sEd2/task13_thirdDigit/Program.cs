// Write a program that displays the third digit of a given 
//number, or reports that there is no third digit.

Console.Write("Enter any number: ");
int num = int.Parse(Console.ReadLine());

if (num < 99)
{
    Console.WriteLine("there is no third digit");
}
if (num < 1000 & num > 99) 
{
    num = num % 10;
    Console.WriteLine($"{num} - the third digit of this number");
}
if (num > 1000) 
{
    while (num / 10 > 99)
    {
       num = num % 10;
       Console.WriteLine($"{num} - the third digit of this number"); 
    }
}