using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class GreedyDwarf
{
    static int[] valley;

    static int CheckCoins(int[] pattern)
    {
        int result = 0;

        bool[] visited = new bool[valley.Length];

        int position = 0;

        for (int i = 0;  ;i++)
        {
            if (i == pattern.Length)
            {
                i = 0;
            }

            if (!(0 <= position && position <= valley.Length - 1))
            {
                break;
            }

            if (visited[position])
            {
                break;
            }

            visited[position] = true;

            result += valley[position];

            position += pattern[i];
        }

        return result;
    }

    static void Main()
    {
#if DEBUG
        Console.SetIn(new StreamReader("../../input.txt"));
#endif

        string valleyString = Console.ReadLine();
        valley = Array.ConvertAll(valleyString.Split(','), input => int.Parse(input));

        int patternsCount = int.Parse(Console.ReadLine());

        var patterns = new List<int[]>();
        for (int i = 0; i < patternsCount; i++)
        {
            string patternString = Console.ReadLine();
            int[] pattern = Array.ConvertAll(patternString.Split(','), input => int.Parse(input));
            patterns.Add(pattern);
        }

        int maxCount = 0;

        for (int i = 0; i < patterns.Count; i++)
        {
            maxCount = Math.Max(CheckCoins(patterns[i]), maxCount);
        }

        Console.WriteLine(maxCount);
    }
}
