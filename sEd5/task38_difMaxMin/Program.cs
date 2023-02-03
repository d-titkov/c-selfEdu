// Task 38: Specify an array of real numbers. Find the difference  
// between the maximum and minimum elements of an array.
// [3, 7, 22, 2, 78] -> 76   

(int[], int) GetArrDiff(int size, int fNumber, int lNumber)
{
    int[] arr = new int[size];
    arr[0] = new Random().Next(fNumber, lNumber);
    int max = arr[0];
    int min = max;
    for (int index = 1; index < size; index++)
    {
        arr[index] = new Random().Next(fNumber, lNumber);
        if (arr[index] < min)
            min = arr[index];
        if (arr[index] > max)
            max = arr[index];
    }
    int dif = max - min;
    return (arr, dif);
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
(int[] value, int diff) array = GetArrDiff(5, 0, 100);
PrintArr(array.value);
PrintResult(array.diff);