// Task 25: Write a loop that takes two numbers as input
// (A and B) and raises the number A to the natural power of B.
// 3, 5 -> 243 (3⁵);      2, 4 -> 16

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
Console.Write($"Enter natural power {number}: ");
int power = int.Parse(Console.ReadLine());

int result = number;
for (int count = 2; count <= power; count++)
{
    result = result * number;
}
Console.WriteLine(number + ", " + power + " -> " + result);