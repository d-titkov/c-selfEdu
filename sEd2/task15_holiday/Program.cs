// Write a program that takes as input a number representing 
//the day of the week and checks if that day is a holiday.

Console.Write("insert a number from 1 to 7 where 1 is Monday and 7 is Sunday to know is that number of the day is holiday: ");
int numDay = int.Parse(Console.ReadLine());

if (numDay == 6 || numDay == 7)
{
    Console.WriteLine("yes, that day is a holiday");
}
else 
{    
    Console.WriteLine("no, that day isn`t a holiday");
}