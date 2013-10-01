using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class PHPVariables
{
    static void Main()
    {
#if DEBUG
        Console.SetIn(new StreamReader("../../test.005.in.txt"));
#endif

        var inputSb = new StringBuilder();
        for (string line; !string.IsNullOrEmpty(line = Console.ReadLine()); inputSb.AppendLine(line));
        var input = inputSb.ToString();

        input = Regex.Replace(input, @"/\*.*?\*/", "", RegexOptions.Singleline);
        input = Regex.Replace(input, @"//.+", "");

        var patterns = new[]
        {
            @"[^\\]\$(\w*)[""']",
            @"[""']\$(\w*)",
            @"\$(\w+)\s?=", 
            @"\$(\w+)\s?\[",
            @"\$(\w+)\s?\;",
            @"\[\$(\w+)\]",
            @"[""'][^\\]*?\$(\w+).*[""']",
            @"\{\$(\w+)\}",
        };

        var variables = new HashSet<string>();

        foreach (var pattern in patterns)
        {
            var matches = Regex.Matches(input, pattern);
            
            foreach (Match match in matches)
            {
                variables.Add(match.Groups[1].Value);
            }
        }

        Console.WriteLine(variables.Count);

        foreach (var variable in variables.OrderBy(x => x,StringComparer.Ordinal))
        {
            Console.WriteLine(variable);
        }
    }
}
