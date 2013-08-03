/*Task 07. Write a program to convert from any numeral system of given base s 
to any other numeral system of base d (2 ≤ s, d ≤  16).*/

using System;
using System.Collections.Generic;

class ConvertToAnyNumeralSystem
{
    static int ToDecimal(string valueToConvert, int baseSystem)
    {
        int result = 0;
        int exponent = 1;

        for (int i = valueToConvert.Length - 1; i >= 0; i--)
        {
            result += InputNumber(valueToConvert[i]) * exponent;
            exponent *= baseSystem;
        }

        return result;
    }

    static string ToTarget(string valueToConvert, int baseSystem, int targetSystem)
    {
        string result = "";
        int number = ToDecimal(valueToConvert, baseSystem);

        while (number != 0)
        {
            result = Letters(number % targetSystem) + result;
            number /= targetSystem;
        }
        return result;
    }

    public static int InputNumber(char value)
    {
        if (char.IsDigit(value))
        {
            return value - '0';
        }
        else
        {
            return (value + 10) - 'A';
        }
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
        int baseSystem = 2;
        int targetSystem = 16;
        string valueToConvert = "11111111";

        Console.WriteLine(ToTarget(valueToConvert, baseSystem, targetSystem));
    }
}
