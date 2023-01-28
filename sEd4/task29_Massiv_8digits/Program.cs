// Task 29: Write a program that takes an array 
// of 8 elements and prints them to the screen.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetRandomArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for(int i = 0;i < arr.Length; i++){
        Console.Write(arr[i]+" ");
    }
}
int[] arr = GetRandomArray(8);
PrintArray(arr);