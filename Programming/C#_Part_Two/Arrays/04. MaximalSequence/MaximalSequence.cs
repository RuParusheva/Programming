/*Task 04. Write a program that finds the maximal sequence of equal elements in an array.
Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.*/

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter sequence values: ");
        string[] userInput = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] sequence = Array.ConvertAll(userInput, int.Parse);

        int counter = 0;
        int value = 0;

        int maxCount = 0;

        for (int i = 0; i < sequence.Length - 1; i++)
        {
            int current = sequence[i];

            for (int j = i + 1; j < sequence.Length; j++)
            {
                if (current != sequence[j])
                {

                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        value = current;
                    }
                    counter = 0;
                    i = j - 1;
                    break;
                }
                else
                {
                    counter++;
                }
            }
        }
        string result = "{";

        for (int i = 0; i <= maxCount; i++)
        {
            result += value;

            if (i != maxCount)
            {
                result += ", ";
            }
        }
        result += "}";
        Console.WriteLine(result);
    }
}
