/*Task 21. Write a program that reads two numbers N and K and generates all the combinations of K distinct elements 
from the set [1..N]. Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}*/

using System;

class DistinctVariations
{
    public static void Variations(int[] array, int index, int current, int range)
    {
        if (array.Length == index)
        {
            Print(array);
        }
        else
        {
            for (int i = current; i <= range; i++)
            {
                array[index] = i;
                Variations(array, index + 1, i + 1,  range);
            }
        }
    }
    public static void Print(int[] array)
    {
        string printOut = "{";

        for (int index = 0; index < array.Length; index++)
        {
            printOut += array[index];

            if (index != array.Length - 1)
            {
                printOut += ", ";
            }
        }
        printOut += "}";
        Console.WriteLine(printOut);
    }
    static void Main()
    {
        Console.WriteLine("Enter values range for the set: ");
        int range = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter size of output set: ");
        int length = int.Parse(Console.ReadLine());

        int[] variations = new int[length];

        Variations(variations, 0, 1, range);
    }
}
