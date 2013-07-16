/*Task 20. Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
Example: N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}*/

using System;


class ElementVariations
{
    public static void Variations(int[] array, int index, int range)
    {
        if (array.Length == index)
        {
            Print(array);
        }
        else
        {
            for (int i = 1; i < range + 1; i++)
            {
                array[index] = i;
                Variations(array, index + 1, range);
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

        Variations(variations, 0, range);
    }
}

