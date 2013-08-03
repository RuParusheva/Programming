//Task 02. Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;

class BinaryToDecimal
{
    public static int BinaryDecimal(string value)
    {
        int result = 0;
        int exponent = 1;

        for (int i = value.Length - 1; i >= 0; i--)
        {
            result += (value[i] - '0') * exponent;
            exponent *= 2;
        }

        return result;
    }

    static void Main()
    {
        string value = "1111001";

        Console.WriteLine(BinaryDecimal(value));
    }
}
