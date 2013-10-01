using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class ConsoleJustification
{
    public static string FilterWhiteSpaces(string input)
    {
        if (input == null)
        {
            return string.Empty;
        }

        StringBuilder output = new StringBuilder(input.Length);
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (i == 0 || c != ' ' || (input[i - 1] != ' '))
            {
                output.Append(c);
            }

        }
        return output.ToString();
    }

    static void Main()
    {
#if DEBUG
        Console.SetIn(new StreamReader("../../input.txt"));
#endif
        int lines = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());

        var output = new StringBuilder();

        for (int i = 0; i < lines; i++)
        {
            string content = Console.ReadLine();
            output.Append(FilterWhiteSpaces(content));
            output.Append(' ');
        }

        var words = output.ToString().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
        var newText = new StringBuilder();

        Console.WriteLine();
    }
}
