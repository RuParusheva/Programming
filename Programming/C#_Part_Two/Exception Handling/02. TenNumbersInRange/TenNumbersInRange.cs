/*Task 02. Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
 If an invalid number or non-number text is entered, the method should throw an exception. 
 Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/

using System;

class TenNumbersInRange
{
    static int ReadNumber(int start, int end)
    {
        int userInput = 0;
        bool isParsed = int.TryParse(Console.ReadLine(), out userInput);

        if (isParsed == false)
        {
            throw new ArgumentException("Non-number text is entered");
        }

        if (start >= userInput || end <= userInput)
        {
            throw new ArgumentException("Invalid number. Value does not meet requirements: 1 < a1 < … < a10 < 100 ");
        }

        return userInput;
    }

    static void Main()
    {
        int start = 1;
        int end = 100;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter a number in the required range: {0}...{1}", start, end);
            ReadNumber(start, end);
        }
    }
}
