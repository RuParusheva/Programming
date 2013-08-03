//Task 04. Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;

class HexadecimalToDecimal
{
    public static int HexaToDecimal(string value)
    {
        int result = 0;
        int exponent = 1;

        for (int i = value.Length - 1; i >= 0; i--)
        {
            result += Numbers(value[i]) * exponent;
            exponent *= 16;
        }

        return result;
    }

    static int Numbers(char number)
    {
        if (char.IsDigit(number))
        {
            return number - '0';
        }
        else
        {
            return (number + 10) - 'A';
        }
    }

    static void Main()
    {
        string value = "13";

        Console.WriteLine(HexaToDecimal(value));
    }
}
