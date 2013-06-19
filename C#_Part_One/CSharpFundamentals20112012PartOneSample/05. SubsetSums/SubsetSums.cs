using System;

class SubsetSums
{
    static void Main()
    {
        long subsetSumValue = long.Parse(Console.ReadLine());
        subsetSumValue = Convert.ToInt64(subsetSumValue);

        int numberOfElements = int.Parse(Console.ReadLine());
        numberOfElements = Convert.ToInt32(numberOfElements);

        long[] set = new long[numberOfElements];

        int counter = 0;
        decimal exponent = 1;

        for (int index = 0; index < numberOfElements; index++)
        {
            set[index] = Convert.ToInt64(Console.ReadLine());
        }

        for (int index = 0; index < set.Length; index++)
        {
            exponent *= 2;
        }

        for (int index = 1; index < exponent; index++)
        {
            long sum = 0;

            for (int value = 0; value < set.Length; value++)
            {
                sum += ((index >> value) & 1) * set[value];
            }
            if (sum == subsetSumValue)
            {
                counter++;
            }

        }
        Console.WriteLine(counter);
    }
}
