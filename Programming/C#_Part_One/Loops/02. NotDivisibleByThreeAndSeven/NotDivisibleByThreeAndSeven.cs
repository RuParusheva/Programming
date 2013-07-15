//Task 02. Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class DivisibleByThreeOrSeven
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int userInput = 0;
        bool isParsed = int.TryParse(Console.ReadLine(), out userInput);

        if (isParsed)
        {
            for (int i = 1; i <= userInput; i++)
            {
                if (i % 21 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("You have entered a number which is out of range, please try a different value.");
        }
    }
}

