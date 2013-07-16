/*Task 07. Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the "selection sort" algorithm: Find the smallest element, move it at the first position,
find the smallest from the rest, move it at the second position, etc.*/

using System;

class SelectionSort
{
    static void Main()
    {
        int[] sequence = new int[] { 5, 27, 15, 99, 33, 18, 1, 6, 4 };

        int swapValue = 0;
        int smallestValueIndex = 0;
        int currentLeft = 0; 
        int currentSmallest = 0; 

        for (int i = 0; i < sequence.Length; i++)
        {
            currentLeft = sequence[i]; 
            currentSmallest = currentLeft; 
            smallestValueIndex = i; 

            for (int j = i + 1; j < sequence.Length; j++)
            {
               
                if (sequence[j] < currentSmallest)
                {
                    smallestValueIndex = j;
                    currentSmallest = sequence[j];
                }
            }

            
            swapValue = currentSmallest;
            sequence[smallestValueIndex] = currentLeft;
            sequence[i] = swapValue;
        }

        Console.WriteLine(string.Join(", ", sequence));
    }
}