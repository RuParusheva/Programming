/*Task 11. Write a program that finds the index of given element in a sorted array of integers by using the 
 binary search algorithm (find it in Wikipedia).*/
 
using System;

class BinarySearch
{
    static void Main()
    {
        int[] sequence = new int[] { 3, 14, 5, 9, 11, 1, 7, 6, 99, 413, 83, 23, 67, 44, 50, 0};

        Array.Sort(sequence);

        int low = 0;
        int high = sequence.Length - 1;
        int middle = 0;
        int valueToFind = 413;
        int counter = 0;


        while (low <= high)
        {
            middle = (low + high) / 2;

            if (sequence[middle] == valueToFind)
            {
                counter++;             
                break;
            }
            else if (valueToFind < sequence[middle])
            {
                high = middle - 1;
            }
            else
            {
                low = middle + 1;
            }
        }
        if (counter == 0)
        {           
            Console.WriteLine("Value is not present. ");
        }
        else
        {
            Console.WriteLine("Value is present. ");
        }
    }
}
