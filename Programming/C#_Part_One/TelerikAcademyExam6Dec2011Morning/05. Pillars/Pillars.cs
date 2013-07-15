using System;

class Pillars
{
    static void Main()
    {
        int[] inputValue = new int[8];

        int[] numberOfBitsOnPosition = new int[8];

        for (int index = 0; index < inputValue.Length; index++)
        {
            inputValue[index] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < inputValue.Length; i++)
        {
            for (int j = 0; j < inputValue.Length; j++)
            {
                if ((inputValue[i] & (1 << j)) != 0)
                {
                    numberOfBitsOnPosition[j]++;
                }
            }
        }

        int leftSum = 0;
        int rigthSum = 0;
        int endSum = 0;
        int pillarPosition = 0;

        bool isPillarPresent = false;

        for (int index = 0; index < inputValue.Length; index++)
        {
            leftSum = 0;
            rigthSum = 0;

            for (int j = 0; j < index; j++)
            {
                leftSum += numberOfBitsOnPosition[j];
            }
            for (int j = index + 1; j < inputValue.Length; j++)
            {
                rigthSum += numberOfBitsOnPosition[j];
            }
            if (leftSum == rigthSum)
            {
                endSum = leftSum;
                pillarPosition = index;
                isPillarPresent = true;
            }

        }
        if (isPillarPresent)
        {
            Console.WriteLine(pillarPosition);
            Console.WriteLine(endSum);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

