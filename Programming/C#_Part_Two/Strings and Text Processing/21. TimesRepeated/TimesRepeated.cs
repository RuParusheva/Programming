/*Task 21. Write a program that reads a string from the console and prints all different letters in
 the string along with information how many times each letter is found. */

using System;
using System.Collections.Generic;

class TimesRepeated
{
    static void Main()
    {
        /*string text = @"The most familiar palindromes, in English at least, are character-by-character: 
The written characters read the same backward as forward.";*/

        Console.WriteLine("Enter string: ");
        string text = Console.ReadLine();

        text = text.ToLower();

        Dictionary<char, int> alphabet = new Dictionary<char, int>();

        var alphabetArray = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        for (int i = 0; i < alphabetArray.Length; i++)
        {
            alphabet.Add(alphabetArray[i], 0);
        }

        foreach (var ch in text)
        {
            if (alphabet.ContainsKey(ch))
            {
                alphabet[ch]++;
            }
            
        }

        foreach (KeyValuePair<char, int> pair in alphabet)
        {
            Console.WriteLine("Letter: {0}, Times repeated: {1}", pair.Key, pair.Value);
        }

    }
}
