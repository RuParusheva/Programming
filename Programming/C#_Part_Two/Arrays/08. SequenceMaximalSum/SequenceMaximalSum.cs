/*Task 08. Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?*/

using System;

class SequenceMaximalSum
{
    static void Main()
    {
        int[] sequence = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int result = int.MinValue;
        int sum = 0;
        int tempStart = 0;

        int startIndex = 0;
        int endIndex = 0;

        //find the maximal sum, start and end element index for given sequence
        for (int index = 0; index < sequence.Length; index++)
        {
            sum += sequence[index];
            if (sum > result)
            {
                result = sum;
                startIndex = tempStart;
                endIndex = index;
            }
            if (sum < 0)
            {
                sum = 0;
                tempStart = index + 1;
            }
        }

        //print the start and end index and elements enclosed between them
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
        Console.WriteLine(printOut);
    }
}

