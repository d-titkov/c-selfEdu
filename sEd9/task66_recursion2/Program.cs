// Task 66: Set the values ​​of M and N. Write a program that will 
// find the sum of positive integers between M and N.
// M = 1; N = 15 -> 120
// M=4; N = 8. -> 30
    
Console.Write("Enter the value of M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Enter the value of N: ");
int N = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = M; i <= N; i++) sum += i;
Console.Write($"M= {M}; N= {N}; -> {sum}");