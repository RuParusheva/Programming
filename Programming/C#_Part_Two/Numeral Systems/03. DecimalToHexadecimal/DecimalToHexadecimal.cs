//Task 03. Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    public static string DecimalHexa(int number)
    {
        string result = "";

        while (number != 0)
        {
            result = Letters(number % 16) + result;
            number /= 16;
        }

        return result;
    }

    public static char Letters(int number)
    {
        if (number < 10)
        {
            return (char)(number + '0');
        }
        else
        {
            char letters = (char)((number - 10) + 'A');
            return letters;
        }

    }

    static void Main()
    {
        int number = 19;
        Console.WriteLine(DecimalHexa(number));
    }
}
