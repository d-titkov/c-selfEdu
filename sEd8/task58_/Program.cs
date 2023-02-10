// Task 58: Define two matrices. Write a
// program that will find the product of two 
// matrices. For example, given 2 matrices::
// 2 4 | 3 4
// 3 2 | 3 3
// The resulting matrix will be:
// 18 20    2*3+4*3=18 2*4+4*3=20
// 15 18    3*3+2*3=15 3*4+2*3=18

int[,] firstMatrix = new int[2, 2] { { 2, 4 }, { 3, 2 } };
int[,] secondMatrix = new int[2, 2] { { 3, 4 }, { 3, 3 } };
int rows = firstMatrix.GetLength(0);
int columns = secondMatrix.GetLength(1);
int innerDimension = secondMatrix.GetLength(0);
int[,] resultMatrix = new int[rows, columns];

for (int i = 0; i < rows; i++) {
    for (int j = 0; j < columns; j++) {
        int sum = 0;
        for (int k = 0; k < innerDimension; k++) {
            sum += firstMatrix[i, k] * secondMatrix[k, j]; }
        resultMatrix[i, j] = sum; } }
for (int i = 0; i < rows; i++) {
    for (int j = 0; j < columns; j++) {
        Console.Write(resultMatrix[i, j] + " "); }
    Console.WriteLine(); }