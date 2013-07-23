/*Task 04. Write a program, that reads from the console an array of N integers and an integer K, 
 sorts the array and using the method Array.BinarySearch() finds the largest number in the array which is ≤ K.*/

using System;
using System.Linq;
using System.Collections.Generic;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter value for array elements: ");
        int range = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for the number K, which will be compared to array elements: ");
        int numberK = int.Parse(Console.ReadLine());

        int[] arr = new int[range];

        for (int i = 0; i < range; i++)
        {
            Console.WriteLine("Array element: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        arr = arr.OrderBy(x => x).ToArray();
        Console.WriteLine(string.Join(" ", arr));

        int index = Array.BinarySearch(arr, numberK);

        if (index < 0)
        {
            Console.WriteLine("Index: " + (~index - 1));
        }
        else
        {
            Console.WriteLine("Index: " + index);
        }
    }
}
