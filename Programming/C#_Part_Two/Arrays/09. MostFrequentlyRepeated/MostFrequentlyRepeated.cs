/*Task 09. Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)*/

using System;

class MostFrequentlyRepeated
{
    static void Main()
    {
        int[] sequence = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        int counter = 0;
        int value = 0;
        int currentValue = 0;
        int maxCount = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            currentValue = sequence[i];

            for (int j = 0; j < sequence.Length; j++)
            {

                if (currentValue == sequence[j])
                {
                    counter++;
                }
            }
            if (maxCount < counter)
            {
                maxCount = counter;
                value = currentValue;
                
            }
            counter = 0;
        }
        Console.WriteLine("Most frequently repeated number is: {0} ({1} times)", value, maxCount);
    }
}

