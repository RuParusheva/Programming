/*Task 03. Write a program that reads from the console a sequence of N integer numbers 
and returns the minimal and maximal of them.*/

using System;
using System.Linq;

class MinMaxValue
{
    static void Main()
    {
        Console.Write("Enter how many values would you like to compare: ");
        int userInput = 0;
        bool isParsed = int.TryParse(Console.ReadLine(), out userInput);
        int[] sequence = new int[userInput];

        if (isParsed)
        {
            for (int index = 0; index < userInput; index++)
            {
                Console.Write("Value: ");
                sequence[index] = int.Parse(Console.ReadLine());
            }
            int minValue = sequence.Min();
            int maxValue = sequence.Max();
            Console.WriteLine("Min value in the given range is {0} and max is {1}", minValue, maxValue);
        }
        else
        {
            Console.WriteLine("You have entered a number which is out of range, please try a different value.");
        }
    }
}

