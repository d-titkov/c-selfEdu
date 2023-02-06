// Task 52. Specify a two-dimensional array of integers. Find the arithmetic 
// mean of the elements in each column. For example, given an array:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Arithmetic mean of each column: 4.6; 5.6; 3.6; 3.

int[,] array = new int[3, 4] 
{ 
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 } 
};
int rows = array.GetLength(0);
int columns = array.GetLength(1);

for (int j = 0; j < columns; j++)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array[i, j];
    }
    double average = (double)sum / rows;
    Console.Write(average.ToString("F1") + "; ");
}