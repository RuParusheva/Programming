/*Task 08. Write a program that reads an integer number n from the console 
and prints all the numbers in the interval [1..n], each on a single line.*/

using System;

class PrintNumbersInRange
{
    static void Main()
    {
        Console.Write("Enter a number bigger than 1: ");
        int inputValue = int.Parse(Console.ReadLine());

        Console.WriteLine("The interval you have chosen is: [1, {0}]", inputValue);

        int counter = 0;
        for (int i = 1; i <= inputValue; i++)
        {
            counter++;
            Console.WriteLine("In scope: {0}", i);
        }
    }
}

