//Task 13. Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

using System;

class MergeSort
{

    public static int[] Sort(int[] arr)
    {
        if (arr.Length == 1)
        {
            return arr;
        }

        int middle = arr.Length / 2;

        int[] left = new int[middle];
        int[] right = new int[arr.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            left[i] = arr[i];
        }
        for (int i = middle; i < arr.Length; i++)
        {
            right[i - middle] = arr[i];
        }

        return Merge(Sort(left),Sort(right));
    }
    public static int[] Merge(int[] arr1, int[] arr2)
    {
        int first = 0;
        int second = 0;
        int third = 0;

        int[] result = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < result.Length; i++)
        {
            if (second>= arr2.Length || first < arr1.Length && arr1[first] < arr2[second])
            {
                result[third] = arr1[first];
                first++;
                third++;
            }
            else if (first>= arr1.Length || second < arr2.Length )
            {
                result[third] = arr2[second];
                second++;
                third++;
            }
        }

        return result;
    }
    public static void Print(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] myArrayOne = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        Print(Sort(myArrayOne));
       
    }


}

