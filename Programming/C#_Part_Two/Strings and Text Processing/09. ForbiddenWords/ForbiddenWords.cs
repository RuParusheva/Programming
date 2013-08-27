/*Task 09. We are given a string containing a list of forbidden words and a text containing some of these words.
 Write a program that replaces the forbidden words with asterisks. Example:
 Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 
 and is implemented as a dynamic language in CLR.
Words: "PHP, CLR, Microsoft"
		The expected result:
********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and 
 is implemented as a dynamic language in ***.
*/

using System;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        string text = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string forbidden1 = "PHP";
        string forbidden2 = "CLR";
        string forbidden3 = "Microsoft";

        var splitted = text.Split(' ');
        var modified = new StringBuilder();

        for (int i = 0; i < splitted.Length; i++)
        {
            if (splitted[i] == forbidden1 || splitted[i] == forbidden2 || splitted[i] == forbidden3)
            {
                splitted[i] = new string('*', splitted[i].Length);
            }
            modified.Append(splitted[i]);
            modified.Append(' ');

        }
        Console.WriteLine(modified);
    }
}
