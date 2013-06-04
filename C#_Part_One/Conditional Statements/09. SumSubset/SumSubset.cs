/*Task 09. We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 
Example: 3, -2, 1, 1, 8 -> 1 + 1- 2 = 0.*/


using System;

class SumSubset
{
    static void Main()
    {
        int[] set = new int[5];

        int counter = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter integer number: ");
            set[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 1; i < 32; i++)
        {
            int sum = 0;

            for (int j = 0; j < 5; j++)
            {
                sum += ((i >> j) & 1) * set[j];
            }
            if (sum == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("The number of subsets, which equal 0 are: {0}", counter);

    }
}
