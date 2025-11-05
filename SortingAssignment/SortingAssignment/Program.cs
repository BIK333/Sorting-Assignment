using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Check out my awesome bubble sort!");

        // Array 1: Brandon's Bubble Sort
        int[] brandonsCoolArray = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
        Console.WriteLine("The contents of the array 'brandonsCoolArray':");
        PrintArray(brandonsCoolArray);

        StudentBubbleSort(brandonsCoolArray);
        Console.WriteLine("The contents of the array 'brandonsCoolArray' after Brandon's bubble sort:");
        PrintArray(brandonsCoolArray);

        // Array 2: Brandon's Library Sort
        int[] brandonsLibrarySortedArray = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
        Console.WriteLine("The contents of the array 'brandonsLibrarySortedArray':");
        PrintArray(brandonsLibrarySortedArray);

        Array.Sort(brandonsLibrarySortedArray);
        Console.WriteLine("The contents of the array 'brandonsLibrarySortedArray' after the C# library sort:");
        PrintArray(brandonsLibrarySortedArray);
    }

    static void StudentBubbleSort(int[] array)
    {
        int temp;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}
