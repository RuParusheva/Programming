//Task 06. Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        uint userInputN = 0;
        bool isParsedN = uint.TryParse(Console.ReadLine(), out userInputN);
        uint valueN = Convert.ToUInt32(userInputN);

        Console.Write("Enter number X: ");
        uint userInputX = 0;
        bool isParsedX = uint.TryParse(Console.ReadLine(), out userInputX);
        uint valueX = Convert.ToUInt32(userInputX);

        decimal factorialN = 1;
        decimal sum = 1;
        decimal xGradated = 1;

        if (isParsedN && isParsedX && valueN != 0 && valueX != 0)
        {
            for (int index = 1; index <= valueN; index++)
            {
                factorialN *= index;

                for (int indexTwo = 1; indexTwo <= valueX; indexTwo++)
                {
                    xGradated = (decimal)Math.Pow(valueX, indexTwo) ;

                    for (int i = 0; i < valueN; i++)
                    {
                        sum += factorialN / xGradated;
                    }
                }

            }
            Console.WriteLine("The sum  of {0} and {1}, where N! is {2} and XN is {3} equals {4}", userInputN, userInputX, factorialN, xGradated, sum);
        }
        else
        {
            Console.WriteLine("Incorrect input value");
        }
    }
}

