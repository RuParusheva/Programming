using System;

class BinaryDigitsCount
{
    static void Main()
    {
        char binaryDigit = char.Parse(Console.ReadLine());

        int numberOfTimes = int.Parse(Console.ReadLine());

        long[] sequence = new long[numberOfTimes];

        string binaryVersion = string.Empty;

        for (int index = 0; index < numberOfTimes; index++)
        {
            sequence[index] = long.Parse(Console.ReadLine());

        }

        for (int index = 0; index < sequence.Length; index++)
        {
            int counter = 0;

            binaryVersion = Convert.ToString(sequence[index], 2);

            for (int i = 0; i < binaryVersion.Length; i++)
            {
                if (binaryVersion[i] == binaryDigit)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

