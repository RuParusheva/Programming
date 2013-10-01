using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

class SpecialValue
{
    static List<int[]> arrays = new List<int[]>();

    static int GetMaxJumps(int col)
    {
        int jumps = 1;
        int specialValue = 0;

        int row = 0;

        bool[,] visited = new bool[arrays.Count, 1000];

        while (true)
        {
            var element = arrays[row][col];
            if (element < 0)
            {
                specialValue = jumps + Math.Abs(element);
                break;
            }

            if (visited[row, col])
            {
                return 0;
            }
            visited[row, col] = true;

            col = element;

            row++;
            jumps++;

            if (row == arrays.Count)
            {
                row = 0;
            }
        }

        return specialValue;
    }
    static void Main()
    {
#if DEBUG
        Console.SetIn(new StreamReader("../../input.txt"));
#endif

        int numberOfRows = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfRows; i++)
        {
            string input = Console.ReadLine();
            int[] row = Array.ConvertAll(input.Split(','), int.Parse);
            arrays.Add(row);
        }

        int maxJumps = 0;
        for (int i = 0; i < arrays[0].Length; i++)
        {
            int current = GetMaxJumps(i);

            if (maxJumps < current)
            {
                maxJumps = current;
            }
        }

        Console.WriteLine(maxJumps);
    }
}
