// Task 23. Write a program that takes as input number (N) 
// and gives a table of cubes of numbers from 1 to N.
// 3 -> 1, 8, 27;      5 -> 1, 8, 27, 64, 125

int getNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}
void OutNumbers(int num)
{
    int i=1;
    while (i<=num)
    {
        Console.Write(Math.Pow(i,3));
        if(i<num) Console.Write(", ");
        i++;
    }
}
// User`s data input
int number = getNum("Input number: ");
OutNumbers(number);