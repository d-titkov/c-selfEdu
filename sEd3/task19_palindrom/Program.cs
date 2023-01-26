// Task19. Write a program that takes as input
// five digit number and checks if it is a palindrome.
// 14212 -> NO, 12821 -> YES, 23432 -> YES

// "solution - string"
// string x = Console.ReadLine();
// if(x[0] == x[4] && x[1] == x [3])


Console.Write("Enter five digit number: ");
int number = int.Parse(Console.ReadLine());
if (number / 10000 == number % 10 && number % 10000 / 1000 == number % 100 / 10)
{
    Console.WriteLine("YES");    
}
else
{
    Console.WriteLine("NO");
}