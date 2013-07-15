/*Task 08. Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
Use the Euclidean algorithm (find it in Internet).*/

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstInput = 0;
        bool isParsedFirst = int.TryParse(Console.ReadLine(), out firstInput);
        int firstValue = Convert.ToInt32(firstInput);

        Console.Write("Enter second number: ");
        int secondInput = 0;
        bool isParsedSecond = int.TryParse(Console.ReadLine(), out secondInput);
        int secondValue = Convert.ToInt32(secondInput);

        int gCD = 0;
        int a = 0;

        if (isParsedFirst && isParsedSecond)
        {
            if (firstValue > secondValue)
            {
                a = secondValue;
                secondValue = firstValue;
                firstValue = a;
            }
            while (secondValue != 0)
            {
                gCD = firstValue % secondValue;
                firstValue = secondValue;

                if (gCD == 0)
                {
                    gCD = secondValue;
                    secondValue = 0;
                }
                else
                {
                    secondValue = gCD;
                }
            }
            Console.WriteLine("GCD is {0}", gCD);
        }
        else
        {
            Console.WriteLine("Error! Try a different entry");
        }
    }
}

