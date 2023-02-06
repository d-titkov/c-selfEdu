// Task 50. Write a program that takes the position of an element 
// in a two-dimensional array as input and returns the value of this 
// element or an indication that there is no such element.
// For example, given an array:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> there is no such number in the array

int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int rows = array.GetLength(0);
int columns = array.GetLength(1);

Console.Write("Enter the row index: ");
int rowIndex = int.Parse(Console.ReadLine());

Console.Write("Enter the column index: ");
int columnIndex = int.Parse(Console.ReadLine());

if (rowIndex >= 0 && rowIndex < rows && columnIndex >= 0 && columnIndex < columns)
{
    int element = array[rowIndex, columnIndex];
    Console.WriteLine("The value at the specified position is: " + element);
}
else
{
    Console.WriteLine("There is no such number in the array");
}

// программа принимает заданный двумерный целочисленный массив;
// просит ввести индексы строки и столбца;
// Если индексы находятся в пределах массива, программа выводит значение указанного элемента.
// Если индексы выходят за границы массива, программа выводит сообщение о том, что
// что такого числа в массиве нет.