using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class ThreeDStars
{
    static char[, ,] cube;

    static void Main()
    {
#if DEBUG
        Console.SetIn(new StreamReader("../../input.txt"));
#endif

        var input = Console.ReadLine().Split();

        int width = int.Parse(input[0]);
        int height = int.Parse(input[1]);
        int depth = int.Parse(input[2]);

        cube = new char[height, depth, width];

        for (int h = 0; h < height; h++)
        {
            var floor = Console.ReadLine().Split();

            for (int d = 0; d < depth; d++)
            {
                var row = floor[d];

                for (int w = 0; w < width; w++)
                {
                    cube[h, d, w] = row[w];
                }
            }
        }

        var results = new Dictionary<char, int>();

        for (int w = 1; w < width - 1; w++)
        {
            for (int h = 1; h < height - 1; h++)
            {
                for (int d = 1; d < depth - 1; d++)
                {
                    if (IsStar(h, d, w))
                    {
                        var c = cube[h, d, w];

                        if (!results.ContainsKey(c))
                        {
                            results.Add(c, 0);
                        }

                        results[c]++;
                    }
                }
            }
        }

        Console.WriteLine(results.Sum(x => x.Value));

        foreach (var result in results.OrderBy(x => x.Key))
        {
            Console.WriteLine("{0} {1}", result.Key, result.Value);
        }
    }

    private static bool IsStar(int h, int d, int w)
    {
        var result =
            cube[h, d, w] == cube[h, d + 1, w] &&
            cube[h, d, w] == cube[h, d - 1, w] &&
            cube[h, d, w] == cube[h + 1, d, w] &&
            cube[h, d, w] == cube[h - 1, d, w] &&
            cube[h, d, w] == cube[h, d, w + 1] &&
            cube[h, d, w] == cube[h, d, w - 1];

        return result;
    }
}
