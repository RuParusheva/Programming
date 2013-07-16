/*Task 17. Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
Find in the array a subset of K elements that have sum S or indicate about its absence.*/

using System;
using System.Collections.Generic;

class UserChoiceSubset
{
    static void Main()
    {
        Console.WriteLine("Enter a value for array elements: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for the subset elements: ");
        int numberK = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter sum value: ");
        int numberS = int.Parse(Console.ReadLine());
        int[] arrayOne = new int[numberN];
        long currentSum = 0;
        long sumSubsets = 0;
        decimal exponent = 1;
        int value = 0;
        List<int> indexCombinations = new List<int>();

        for (int index = 0; index < arrayOne.Length; index++)
        {
            Console.WriteLine("Array element: ");
            arrayOne[index] = int.Parse(Console.ReadLine());
        }
        for (int index = 0; index < arrayOne.Length; index++)
        {
            exponent *= 2;
        }
        for (int index = 1; index < exponent; index++)
        {
            currentSum = 0;
            indexCombinations.RemoveRange(0, indexCombinations.Count);

            for (value = 0; value < arrayOne.Length; value++)
            {
                currentSum += ((index >> value) & 1) * arrayOne[value];

                if (((index >> value) & 1) != 0)
                {
                    indexCombinations.Add(arrayOne[value]);
                }
            }
            if (currentSum == numberS && indexCombinations.Count == numberK)
            {
                value = 0;
                sumSubsets++;
                Console.Write(" S = {0} subset {1} matching required elements count {2} -> ", numberS, sumSubsets, numberK);
                foreach (long item in indexCombinations)
                {
                    Console.Write("{0} ", indexCombinations[value] + " ");
                    value++;
                }
                Console.WriteLine();
            }
        }
        if (sumSubsets == 0)
        {
            Console.WriteLine("No subsets match the requirements- either subset element count or sum should be adjusted)!");
        }
    }
}

