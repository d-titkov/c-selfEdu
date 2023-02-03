// Task 36: Define a one-dimensional array filled with random numbers.
//  Find the sum of elements in uneven positions..
// [7, 3, 12, 23] -> 19   // [-6, -4, 6, 89] -> 0

(int[], int) GetArrUneven(int size, int fNumber, int lNumber)
{
    int[] arr = new int[size];
    int sum = 0;
    for (int index = 0; index < size; index++)
    {
        arr[index] = new Random().Next(fNumber, lNumber);
        if (index % 2 == 0 || index == 0)
            sum += arr[index];
    }
    return (arr, sum);
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
(int[] value, int uneven) array = GetArrUneven(4, -99, 100);
PrintArr(array.value);
PrintResult(array.uneven);