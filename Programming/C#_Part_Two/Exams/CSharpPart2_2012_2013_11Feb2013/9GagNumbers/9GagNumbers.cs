using System;
using System.Collections.Generic;

class NineGagNumbers
{
    public static ulong Power(int i)
    {
        ulong result = 1;

        for (int j = 0; j < i; j++)
        {
            result *= 9;
        }
        return result;
    }

    public static List<string> NineGagSeparator(string input)
    {
        List<string> separated = new List<string>();
        List<string> cases = new List<string> { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };

        while (input != string.Empty)
        {
            foreach (var @case in cases)
            {
                if (input.StartsWith(@case))
                {
                    separated.Add(@case);
                    input = input.Substring(@case.Length);
                }

            }
        }

        return separated;
    }

    static ulong Converter(List<string> separated)
    {
        ulong result = 0;

        separated.Reverse();

        for (int i = 0; i < separated.Count; i++)
        {

            result += BaseCase(separated[i]) * Power(i);

        }

        return result;
    }

    static ulong BaseCase(string input)
    {
        switch (input)
        {
            case "-!":
                return 0;
            case "**":
                return 1;
            case "!!!":
                return 2;
            case "&&":
                return 3;
            case "&-":
                return 4;
            case "!-":
                return 5;
            case "*!!!":
                return 6;
            case "&*!":
                return 7;
            case "!!**!-":
                return 8;
            default:
                throw new Exception("No such number");
        }
    }

    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(Converter(NineGagSeparator(input)));
    }
}
