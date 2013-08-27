/*Task 13. Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".*/

using System;
using System.Collections.Generic;
using System.Text;

internal class ReverseByWords
{
    public static string ReverseWords(string text)
    {
        string[] words = text.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }

    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";

        List<char> symbols = new List<char>();
        List<int> positions = new List<int>();

        char[] chars = text.ToCharArray();
        var modified = new StringBuilder();

        for (int i = 0; i < chars.Length; i++)
        {
            if (Char.IsPunctuation(chars[i]) && chars[i] != '#')
            {
                symbols.Add(chars[i]);
                positions.Add((chars.Length - 1)- i);
                chars[i] = ' ';
            }
            modified.Append(chars[i]);
        }

        var result = modified.ToString();

        result = ReverseWords(result);

        for (int i = 0; i < symbols.Count; i++)
        {
            result = result.Insert(positions[i], symbols[i].ToString());
        }

        Console.WriteLine(result);
    }
}
