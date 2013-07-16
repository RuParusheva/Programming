/*Task 05. Write a program that finds the maximal increasing sequence in an array. 
Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.*/

using System;
using System.Collections.Generic;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter sequence values: ");
        string[] userInput = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] sequence = Array.ConvertAll(userInput, int.Parse);

        int[] maxSequence = new int[0];

        List<int> currentSequence = new List<int>();

        currentSequence.Add(sequence[0]);

        for (int index = 1; index < sequence.Length; index++)
        {
            bool isGreater = sequence[index] >= sequence[index - 1];
            if (isGreater == false)
            {
                if (currentSequence.Count > maxSequence.Length)
                {
                    maxSequence = currentSequence.ToArray();
                }

                currentSequence.Clear();
            }

            currentSequence.Add(sequence[index]);
        }
        string result = "{";
        result += string.Join(", ", maxSequence);
        result += "}";

        Console.WriteLine(result);
    }
}

