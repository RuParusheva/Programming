/*Task 20. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".*/

using System;
using System.Text;
using System.Text.RegularExpressions;

class GetPalindromes
{
    public static bool IsPalindrome(string input)
    {
        int start = 0;
        int end = input.Length - 1;

        while (true)
        {
            if (start > end)
            {
                return true;
            }

            char a = input[start];
            char b = input[end];

            if (char.ToLower(a) != char.ToLower(b))
            {
                return false;
            }
            start++;
            end--;
        }
    }

    static void Main()
    {
        string text = @"The most familiar palindromes, in English at least, are character-by-character: 
The written characters read the same backward as forward. Some examples of common palindromic words: 
civic, radar, level, rotor, kayak, reviver, racecar, redder, madam, malayalam, and refer. 
There are also palindromes where the unit of reversal is the word (""So patient a doctor to doctor a patient so"") or
line (as in the poem ""Doppelganger"" by J.A. Lindon). These are referred to as ""word-unit palindromes"" 
and ""line-unit palindromes"" respectively. Word-unit palindromes were popularized in the recreational 
linguistics community by J.A. Lindon in the 1960s, but occasional examples in English are found from at least 
the 19th century, and several in French and Latin date to the Middle Ages";

        var palindromes = new StringBuilder();

        foreach (var word in Regex.Matches(text, @"\w+"))
        {
            if (IsPalindrome(word.ToString()))
            {
                palindromes.Append(word);
                palindromes.Append("; ");
            }
        }

        Console.WriteLine(palindromes);
    }
}
