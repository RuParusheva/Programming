﻿/*Task 06. You are given a sequence of positive integer values written into a string, separated by spaces.
 Write a function that reads these values from given string and calculates their sum. Example:
		string = "43 68 9 23 318" -> result = 461*/

using System;

class NumbersSum
{
    static uint CalculateSum(string[] stringArray)
    {
        uint[] sequence = Array.ConvertAll(stringArray, uint.Parse);
        uint result = 0;

        foreach (uint number in sequence)
        {
            result += number;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter sequence values: ");
        string[] userInput = Console.ReadLine().Split(' ');

        Console.WriteLine("result = {0}", CalculateSum(userInput));
    }
}
