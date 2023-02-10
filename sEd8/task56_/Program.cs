// Task 56: Specify a rectangular two-dimensional array. Write
// a program that will find the line with the smallest sum
// elements. For example, given an array:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// The program counts the sum of the elements in each line and gives the number
// rows with the smallest sum of elements: 1 row

int[,] array = new int[4, 4] { { 8, 4, 2, 4 }, { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 5, 2, 6, 7 } };
int minRowIndex = 0;
int minSum = int.MaxValue;
for (int i = 0; i < array.GetLength(0); i++)
{int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
    if (sum < minSum) {minSum = sum; minRowIndex = i;}}
Console.WriteLine("The row with the smallest sum of elements is: " + (minRowIndex + 1));