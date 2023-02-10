// Task 64: Set a value to N. Write a program that prints all natural numbers 
// between N and 1. Execute using recursion.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  

Console.Write("Enter the value of N = ");
int N = int.Parse(Console.ReadLine());
Console.Write("-> ");
PrintNumbers(N);
void PrintNumbers(int N) {
    if (N == 0) return;
    Console.Write(N + ", ");
    PrintNumbers(N - 1);}