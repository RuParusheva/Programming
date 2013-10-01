using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class CSharpBrackets
{
    static string Repeat(string s, int count)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            sb.Append(s);
        }

        return sb.ToString();
    }

    static void Main()
    {
#if DEBUG
        Console.SetIn(new StreamReader("../../input.txt"));
#endif
        int numberOfLines = int.Parse(Console.ReadLine());

        string indentation = Console.ReadLine();

        var sb = new StringBuilder();

        for (int i = 0; i < numberOfLines; i++)
        {
            string input = Console.ReadLine();
            sb.AppendLine(input);
        }

        var code = sb.ToString().Replace("\r", "");

        var modified = new StringBuilder();
        int level = 0;

        foreach (char c in code)
        {
            if (c == '{')
            {
                modified.AppendLine();
                modified.Append(Repeat(indentation, level));
                modified.Append("{");
                level++;

                modified.AppendLine();
                modified.Append(Repeat(indentation, level));
            }
            else if (c == '}')
            {
                level--;
                modified.AppendLine();
                modified.Append(Repeat(indentation, level));
                modified.Append("}");

                modified.AppendLine();
                modified.Append(Repeat(indentation, level));
            }
            else if (c == '\n')
            {
                modified.AppendLine();
                modified.Append(Repeat(indentation, level));
            }
            else
            {
                modified.Append(c);
            }
        }

        var result = Regex.Replace(modified.ToString(), @" +", " ");
        result = Regex.Replace(result, @"^(" + Regex.Escape(indentation) + ")*\r\n", "", RegexOptions.Multiline);
        Console.Write(result);
    }
}
