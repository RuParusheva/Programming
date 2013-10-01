using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class GenomeDecoder
{
    static string Decode(string genomeEncoded)
    {
        var decoded = new StringBuilder();

        var patterns = Regex.Matches(genomeEncoded, @"(\d*)([A-Z])");


        foreach (Match pattern in patterns)
        {
            int number = 0;

            if (pattern.Groups[1].Value != string.Empty)
            {
                number = int.Parse(pattern.Groups[1].Value);
            }

            else
            {
                number = 1;
            }

            decoded.Append(pattern.Groups[2].Value[0], number);

        }

        return decoded.ToString();
    }

    static void Print(string decoded, int n, int m)
    {
        int rows = (int)(Math.Ceiling((double)decoded.Length / n));

        var result = new StringBuilder();

        decoded = decoded.PadRight(rows * n, ' ');
        for (int i = 1; i <= rows; i++)
        {

            result.Append(i.ToString().PadLeft(rows.ToString().Length, ' '));
            var substring = decoded.Substring((i - 1) * n, n);

            for (int j = 0; j < Math.Ceiling((double)n / m); j++)
            {
                substring = substring.Insert(m * (j) + j, " ");
            }

            result.Append(substring);
            result.AppendLine();
        }
        Console.WriteLine(result.ToString().TrimEnd());
    }
    static void Main()
    {
#if DEBUG
        Console.SetIn(new StreamReader("../../input.txt"));
        var streamWriter = new StreamWriter("../../out.txt");
        Console.SetOut(streamWriter);
#endif

        string nAndM = Console.ReadLine();
        int[] numbers = Array.ConvertAll(nAndM.Split(' '), int.Parse);

        string genomeEncoded = Console.ReadLine();

        //Console.WriteLine(Decode(genomeEncoded));
        Print(Decode(genomeEncoded), numbers[0], numbers[1]);
#if DEBUG
        streamWriter.Dispose();
#endif
    }
}
