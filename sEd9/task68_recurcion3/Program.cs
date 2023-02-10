// Task 68: Write a program to calculate the Ackermann function using recursion 
// (habr.com/ru/post/486548). Two non-negative numbers m and n are given.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n) {
if (m == 0) return n + 1;
else if (m > 0 && n == 0) return Ackermann(m - 1, 1);
else if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
else return -1;}
Console.WriteLine("Ackermann(2, 3) = " + Ackermann(2, 3));
Console.WriteLine("Ackermann(3, 2) = " + Ackermann(3, 2));