// Task 34: Define an array filled with random positive three-digit numbers. 
// Write a program to show the number of even numbers in an array.
// [345, 897, 568, 234] -> 2

(int[], int) GetRandomArray(int size, int fNumber, int lNumber)
{
    int[] arr = new int[size];
    int count = 0;
    for (int index = 0; index < size; index++)
    {
        arr[index] = new Random().Next(fNumber, lNumber);
        if (arr[index] % 2 == 0)
        count++;
    }
    return (arr, count);
}
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int index = 0; index < arr.Length; index++)
        if (index < arr.Length - 1)
        Console.Write($"{arr[index]}, ");
    Console.Write($"{arr[arr.Length - 1]}]");
}
void PrintResult(int num)
{
    Console.Write($" -> {num}");
}
(int[] value, int result) array = GetRandomArray(4, 100, 1000);
PrintArr(array.value);
PrintResult(array.result);