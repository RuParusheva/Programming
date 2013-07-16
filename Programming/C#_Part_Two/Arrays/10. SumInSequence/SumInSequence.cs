/*Task 10. Write a program that finds in given array of integers a sequence of given sum S (if present). 
Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}*/

using System;

class SumInSequence
{
    static void Main()
    {
        int[] sequence = new int[] { 4, 3, 1, 4, 2, 5, 8 };


        int maxSum = 11;
        int startIndex = 0;
        int endIndex = 0;
        int counter = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            for (int j = i; j < sequence.Length; j++)
            {

                int thisSum = 0;

                for (int k = i; k <= j; k++)
                {
                    thisSum += sequence[k];

                }

                if (thisSum == maxSum)
                {
                    startIndex = sequence[i] - 1;
                    endIndex = sequence[j];
                    counter++;
                }
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("There are no sequences that match the given sum {0}. ", maxSum);
        }
        else
        {
            string printOut = "{";

            for (int index = startIndex; index <= endIndex; index++)
            {
                printOut += sequence[index];

                if (index != endIndex)
                {
                    printOut += ", ";
                }
            }
            printOut += "}";
            Console.Write("S = {0} -> ", maxSum);
            Console.WriteLine(printOut);
        }
    }
}

