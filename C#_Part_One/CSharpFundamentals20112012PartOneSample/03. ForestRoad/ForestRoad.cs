using System;

class ForestRoad
{
    static void Main()
    {
        byte mapWidth = byte.Parse(Console.ReadLine());

        int innerPath = mapWidth - 1;
        int outerPath = 0;

        for (int index = 0; index < mapWidth - 1; index++)
        {
            Console.Write(new string('.', outerPath));
            Console.Write("*");
            Console.Write(new string('.', innerPath));
            Console.WriteLine();
            innerPath--;
            outerPath++;
        }
        for (int index = 0; index <= mapWidth - 1; index++)
        {

            Console.Write(new string('.', outerPath));
            Console.Write("*");
            Console.Write(new string('.', innerPath));            
            Console.WriteLine();           
            innerPath++;
            outerPath--;
        }
    }
}

