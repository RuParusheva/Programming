using System;
using System.Collections.Generic;

class DurankulakNumbers
{
    public static bool IsLowercase(char c)
    {
        return 'a' <= c && c <= 'z';
    }

    public static long DurankulakConvert(string input)
    {
        long output = 0;
        List<string> result = new List<string>();

        for (int i = 0; i < input.Length; i++)
        {
            if (IsLowercase(input[i]))
            {
                result.Add(input[i] + input[i + 1].ToString());
                i++;
            }
            else
            {
                result.Add(input[i].ToString());
            }
        }

        result.Reverse();
        for (int i = 0; i < result.Count; i++)
        {
            output += ConvertToDecimal(result[i]) * (long)(Math.Pow(168, i));
        }
        return output;
    }

    private static int ConvertToDecimal(string input)
    {
        int output = 0;

        if (input.Length == 1)
        {
            output = (input[0] - 'A');
            return output;
        }
        else
        {
            output = 26 * (input[0] - 'a' + 1) + (input[1] - 'A');
            return output;
        }
    }
    static void Main()
    {
        /*#if DEBUG
                Console.SetIn(new StringReader(""));
        #endif*/

        string input = Console.ReadLine();
        Console.WriteLine(DurankulakConvert(input));
    }
}
