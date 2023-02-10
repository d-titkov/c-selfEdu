// Task 54: Specify a two-dimensional array. Write a program
// which will sort the elements of each row in descending order
// two-dimensional array. For example, given an array:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int rows = array.GetLength(0);
int columns = array.GetLength(1);
for (int i = 0; i < rows; i++) {
    for (int j = 0; j < columns - 1; j++) {
        for (int k = 0; k < columns - j - 1; k++) {
            if (array[i, k] < array[i, k + 1]) {
                int temp = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = temp; } } } }
for (int i = 0; i < rows; i++) {
    for (int j = 0; j < columns; j++) {
        Console.Write(array[i, j] + " "); }
Console.WriteLine();}