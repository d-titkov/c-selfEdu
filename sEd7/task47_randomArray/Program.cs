// Task 47. Specify a two-dimensional array of size m×n, 
// filled with random real numbers.  m = 3, n = 4.

int rows = 3;
int columns = 4;
Random numbers = new Random();
double[,] array = new double[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = Math.Round(numbers.NextDouble() * 10, 1);
    }
}
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(array[i, j] + "    ");
    }
    Console.WriteLine();
}