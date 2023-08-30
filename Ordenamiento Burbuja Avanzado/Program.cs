using System;

class Program
{
    static void BubbleSortOptimized(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
    }

    static void Main(string[] args)
    {
        int[] myArray = { 64, 34, 25, 12, 22, 11, 90 };
        BubbleSortOptimized(myArray);
        Console.WriteLine("Array ordenado:");
        foreach (int num in myArray)
        {
            Console.Write(num + " ");
        }
    }
}
