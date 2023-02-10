// Task 62: Write a program that fills a 4 by 4 array helix.
// For example, the output is the following array:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07 

int[,] matrix = new int[4, 4];
int value = 1;
int startRow = 0;
int endRow = matrix.GetLength(0) - 1;
int startCol = 0;
int endCol = matrix.GetLength(1) - 1;

while (value <= 16) {
    for (int i = startCol; i <= endCol; i++) {
        matrix[startRow, i] = value;
        value++; }
    startRow++;
    for (int i = startRow; i <= endRow; i++) {
        matrix[i, endCol] = value;
        value++; }
    endCol--;
    for (int i = endCol; i >= startCol; i--) {
        matrix[endRow, i] = value;
        value++; }
    endRow--;
    for (int i = endRow; i >= startRow; i--) {
        matrix[i, startCol] = value;
        value++; }
    startCol++; }
for (int i = 0; i < 4; i++) {
    for (int j = 0; j < 4; j++) {
        Console.Write(matrix[i, j].ToString().PadLeft(2, '0') + " "); }
    Console.WriteLine(); }