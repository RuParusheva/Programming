/*Task 03. Write a method that returns the last digit of given integer as an English word.
 Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".*/

using System;

class GetLastDigitName
{
    public static int GetLastDigit(int value)
    {
        return value % 10;
    }

    public static string GetName(int digit)
    {
        string[] digitNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        return digitNames[digit];
    }

    static void Main()
    {
        Console.WriteLine(GetName(GetLastDigit(int.Parse(Console.ReadLine()))));
    }
}
