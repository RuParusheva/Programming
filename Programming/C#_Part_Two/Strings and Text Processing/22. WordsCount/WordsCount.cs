/*Task 22. Write a program that reads a string from the console and lists all different words in the string 
along with information how many times each word is found.*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class WordsCount
{
    static void Main()
    {
        /*string text = @"The most familiar palindromes, in English at least, are character-by-character: 
The written characters read the same backward as forward. Some examples of common palindromic words: 
civic, radar, level, rotor, kayak, reviver, racecar, redder, madam, malayalam, and refer. 
There are also palindromes where the unit of reversal is the word (""So patient a doctor to doctor a patient so"") or
line (as in the poem ""Doppelganger"" by J.A. Lindon). These are referred to as ""word-unit palindromes"" 
and ""line-unit palindromes"" respectively. Word-unit palindromes were popularized in the recreational 
linguistics community by J.A. Lindon in the 1960s, but occasional examples in English are found from at least 
the 19th century, and several in French and Latin date to the Middle Ages";*/
        Console.WriteLine("Enter string: ");
        string text = Console.ReadLine();

        Dictionary<string, int> wordDictionary = new Dictionary<string, int>();

        foreach (var word in Regex.Matches(text, @"\w+"))
        {
            if (!wordDictionary.ContainsKey(word.ToString()))
            {
                wordDictionary.Add(word.ToString(), 0);
            }

            wordDictionary[word.ToString()]++;            
        }

        foreach (KeyValuePair<string, int> pair in wordDictionary)
        {
            Console.WriteLine("Word: {0}, Times repeated: {1}", pair.Key, pair.Value);
        }
    }
}
