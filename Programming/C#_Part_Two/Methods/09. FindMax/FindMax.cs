/*Task 09. Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.*/

using System;

class FindMax
{
    public static int Max(int[] array, int indexToCheck = 0)
    {
        int max = indexToCheck;

        for (int i = indexToCheck + 1; i < array.Length; i++)
        {
            if (array[max] < array[i])
            {
                max = i;
            }
        }

        return max;
    }

    public static int Min(int[] array, int indexToCheck = 0)
    {
        int min = indexToCheck;

        for (int i = indexToCheck + 1; i < array.Length; i++)
        {
            if (array[min] > array[i])
            {
                min = i;
            }
        }

        return min;
    }

    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static void DescendingSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Swap(array, i, Max(array, i));
        }
    }

    public static void AscendingSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Swap(array, i, Min(array, i));
        }
    }

    static void Main()
    {
        int[] myArray = { 3, 5, 17, 77, 88, 14, 0, 28, 17, 66, 19, 1 };

        //int indexToCheck = int.Parse(Console.ReadLine());
        int indexToCheck = 3;
        
        int maxIndex = Max(myArray, 3);
        Console.WriteLine("Maximal element is: {0}", myArray[maxIndex]);

        DescendingSort(myArray);
        Console.WriteLine(string.Join(" ", myArray));
        AscendingSort(myArray);
        Console.WriteLine(string.Join(" ", myArray));
    }
}
