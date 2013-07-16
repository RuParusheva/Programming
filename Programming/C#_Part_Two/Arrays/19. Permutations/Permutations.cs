/*Task 19. Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
Example: n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}*/

using System;
using System.Collections;
using System.Collections.Generic;

class Permutations
{
    public static void Print(IList sequence, int count)
    {
        string printOut = "{";

        for (int index = 0; index < sequence.Count; index++)
        {
            printOut += sequence[index];

            if (index != sequence.Count - 1)
            {
                printOut += ", ";
            }
        }
        printOut += "}";
        Console.WriteLine(printOut);
    }
    public static void RotateRight(IList sequence, int count)
    {
        //This method makes a swap of the list elements to the right
        object tmp = sequence[count - 1];
        sequence.RemoveAt(count - 1);
        sequence.Insert(0, tmp);
    }
    public static IEnumerable<IList> Permutate(IList sequence, int count)
    {
        //Recursion floor
        if (count == 1)
        {
            yield return sequence;
        }
        //Recursively repeat swap for each sequence element
        else
        {
            for (int i = 0; i < count; i++)
            {
                foreach (var perm in Permutate(sequence, count - 1))
                {
                    yield return perm;
                }
                RotateRight(sequence, count);
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter a number for permutations range: ");
        int range = int.Parse(Console.ReadLine());

        List<int> sequence = new List<int>();

        //This loop generates the sequence elements, which will be permutated
        for (int i = 1; i <= range; i++)
        {
            sequence.Add(i);
        }

        foreach (var permutation in Permutate(sequence, sequence.Count))
        {
            Print(sequence, sequence.Count);
        }
    }
}

