//Task 41: The user enters M numbers from the keyboard.
// Count how many numbers greater than 0 the user entered.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Enter the number of values you want to enter: ");
int numberOfValues = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < numberOfValues; i++)
{
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine());
    if (number > 0) count++;
}
Console.WriteLine("->" + count);