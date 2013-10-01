using System;
using System.Collections.Generic;

class JoroTheRabbit
{
    static int[] terrain;

    static int MaxJumps(int startPosition, int step)
    {
        int result = 1;

        while (true)
        {
            int nextPosition = startPosition + step;

            if (nextPosition >= terrain.Length)
            {
                nextPosition -= terrain.Length;
            }

            if (!(terrain[startPosition] < terrain[nextPosition]))
            {
                break;
            }

            startPosition = nextPosition;

            result++;
        }

        return result;
    }

    static void Main()
    {
        string terrainString = Console.ReadLine();

        terrain = Array.ConvertAll(terrainString.Split(','), int.Parse);

        int maxLength = 0;

        for (int step = 1; step < terrain.Length; step++)
        {
            for (int startPosition = 0; startPosition < terrain.Length; startPosition++)
            {
                int length = MaxJumps(startPosition, step);

                if (maxLength < length)
                {
                    maxLength = length;
                }
            }
        }

        Console.WriteLine(maxLength);
    }
}
