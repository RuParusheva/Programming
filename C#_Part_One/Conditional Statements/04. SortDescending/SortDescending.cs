//Task 04. Sort 3 real values in descending order using nested if statements.

using System;

class SortDescending
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstValue = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondValue = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdValue = double.Parse(Console.ReadLine());

        if (firstValue >= secondValue)
        {
            if (firstValue >= thirdValue)
            {
                if (secondValue >= thirdValue)
                {
                    Console.WriteLine("Numbers in descending order are: {0}, {1}, {2}", firstValue, secondValue, thirdValue);
                }
                else
                {
                    Console.WriteLine("Numbers in descending order are: {0}, {1}, {2}", firstValue, thirdValue, secondValue);
                }
            }
        }
        else if (secondValue >= firstValue)
        {
            if (secondValue >= thirdValue)
            {
                if (firstValue >= thirdValue)
                {
                    Console.WriteLine("Numbers in descending order are: {0}, {1}, {2}", secondValue, firstValue, thirdValue);
                }
                else
                {
                    Console.WriteLine("Numbers in descending order are: {0}, {1}, {2}", secondValue, thirdValue, firstValue);
                }
            }
            else
            {
                Console.WriteLine("Numbers in descending order are: {0}, {1}, {2}", thirdValue, secondValue, firstValue);
            }
        }
        else
        {
            if (secondValue >= firstValue)
            {
                Console.WriteLine("Numbers in descending order are: {0}, {1}, {2}", thirdValue, secondValue, firstValue);
            }
            else
            {
                Console.WriteLine("Numbers in descending order are: {0}, {1}, {2}", thirdValue, firstValue, secondValue);
            }
        }
    }
}

