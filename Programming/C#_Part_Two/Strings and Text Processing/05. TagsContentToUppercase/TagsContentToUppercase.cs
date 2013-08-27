/*Task 05. You are given a text. Write a program that changes the text in all regions surrounded by
the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
The expected result:
We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/

using System;
using System.Text.RegularExpressions;

class TagsContentToUppercase
{
    static void Main()
    {
        string text = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        var splitted = text.Split('>');

        for (int i = 0; i < splitted.Length; i++)
        {
            if (splitted[i].Contains("</"))
            {
                var modify = splitted[i].Split('<');

                modify[0]= modify[0].ToUpper();
                splitted[i] = modify[0];
            }
        }

        string modified = string.Concat(splitted);
        var pattern = new Regex(@"<upcase");
        modified = pattern.Replace(modified, "");
        modified = Regex.Replace(modified, " {2,}", " ");

        Console.WriteLine(modified);
    }
}