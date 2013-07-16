/*Task 16. We are given an array of integers and a number S. Write a program to find if there exists 
a subset of the elements of the array that has a sum S. Example:
	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)*/

using System;
using System.Collections.Generic;

class SubsetSum
{
    static void Main()
    {
        int[] arrayOne = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };

        int sumToFind = 14;
        long currentSum = 0;
        long sumSubsets = 0;
        decimal exponent = 1;
        int value = 0;       
        List<int> indexCombinations = new List<int>();

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
            if (currentSum == sumToFind)  
            {
                value = 0;
                sumSubsets++;                                                          
                Console.Write(" S = {0} subset {1} -> ", sumToFind, sumSubsets);
                foreach (long item in indexCombinations)
                {
                    Console.Write("{0} ", indexCombinations[value] + " ");
                    value++;
                }
                Console.WriteLine();
            }

        }
        Console.WriteLine("\nTotal count of subsets with that sum is: {0}", sumSubsets);
    }
}

