//Task 01. Write a program that prints all the numbers from 1 to N.

using System;

class PrintNumbers
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int userInput = 0;
        bool isParsed = int.TryParse(Console.ReadLine(), out userInput);

        if (isParsed)
        {
            for (int index = 1; index <= userInput; index++)
            {
                Console.WriteLine(index);
            }
        }
        else
        {
            Console.WriteLine("You have entered a number which is out of range, please try a different value.");
        }
    }
}

