//Task 01. Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;

class DecimalToBinary
{
    public static string DecimalBinary(int number)
    {
        string result = "";

        while (number != 0)
        {
            result = (number % 2) + result;
            number /= 2;
        }
        return result;
    }

    static void Main()
    {
        int number = 121;
        Console.WriteLine(DecimalBinary(number));
    }
}
