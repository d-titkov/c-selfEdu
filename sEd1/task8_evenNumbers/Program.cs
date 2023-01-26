// Write a program that takes a number (N) 
//as input and outputs all even numbers from 1 to N

Console.Write("insert a number N: ");
int numberN = int.Parse(Console.ReadLine());
int count = 2;
while (count <= numberN)
{
    Console.Write(count + ", ");
    count = count + 2;
}