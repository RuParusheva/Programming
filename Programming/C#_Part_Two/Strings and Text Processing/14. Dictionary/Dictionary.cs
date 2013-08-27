/*Task 14. A dictionary is stored as a sequence of text lines containing words and their explanations. 
 Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
.NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes*/

using System;
using System.Collections.Generic;

class Dictionary
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add(".NET", "platform for applications from Microsoft");
        dict.Add("CLR", "managed execution environment for .NET");
        dict.Add("namespace", "hierarchical organization of classes");

        List<string> list = new List<string>(dict.Keys);
        
        foreach (string word in list)
        {
            Console.WriteLine("{0} - {1}", word, dict[word]);
        }
    }
}
