/*Task 18. Write a program that reads an array of integers and removes from it a minimal number of elements in such way 
that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
	{6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}*/

using System;
using System.Collections.Generic;

class IncreasingOrder
{
    public static bool isSorted(List<int> list)
    {
        bool isSorted = true;

        for (int index = 0; index < list.Count - 1; index++)
        {
            if (list[index] > list[index + 1])
            {
                isSorted = false;
            }
        }
        return isSorted;
    }
    public static void Print(List<int> list)
    {
        string printOut = "{";

        for (int index = 0; index < list.Count; index++)
        {
            printOut += list[index];

            if (index != list.Count - 1)
            {
                printOut += ", ";
            }
        }
        printOut += "}";
        Console.WriteLine(printOut);
    }
    static void Main()
    {
        List<int> sequence = new List<int>() { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        List<int> sorted = new List<int>();
        decimal exponent = 1;
        int length = 0;

        for (int index = 0; index < sequence.Count; index++)
        {
            exponent *= 2;
        }
        for (int index = 1; index <= exponent; index++)
        {
            List<int> temp = new List<int>();
            int counter = 0;

            for (int value = 1; value <= sequence.Count; value++)
            {
                if (((index >> (value - 1)) & 1) == 1)
                {
                    temp.Add(sequence[value - 1]);
                    counter++;
                }
            }

            if (counter > length && isSorted(temp))
            {
                sorted = temp;
                length = counter;
            }

            counter = 0;
        }

        Print(sorted);
    }
}
