using System;
using System.Collections.Generic;
using System.Linq;

class OneTaskIsNotEnough
{
    static int FirstTask(int lamps)
    {
        bool[] turned = new bool[lamps + 1];
        int index = 0;
        int count = 1;
        int i = 1;
        int increment = 0;
        int toCheck = lamps + 1;

        turned[0] = true;

        while (true)
        {
            increment = i + 1;

            while (count < toCheck)
            {
                bool current = turned[count];

                if (current == false)
                {
                    turned[count] = true;
                }
                index = count;
                count += increment;
            }

            i++;
            count = i;
            if (turned.All(x => x))
            {
                break;
            }

        }
        return index;
    }

    static string SecondTask(string commands)
    {
        int[] movesX = {1, 0, -1, 0};
        int[] movesY = {0, 1, 0, -1};

        int currentX = 0, currentY = 0, direction = 0;

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j < commands.Length; j++)
            {
                switch (commands[j])
                {
                    case 'S':
                        currentX += movesX[direction];
                        currentY += movesY[direction];
                        break;
                    case 'L':
                        direction = (direction + 3)%4;
                        break;
                    case 'R':
                        direction = (direction + 1)%4;
                        break;
                }
            }
        }

        if (currentX == 0 && currentY == 0)
        {
            return "bounded";
        }
        else
        {

            return "unbounded";
        }
    }

    static void Main()
    {
        int lamps = int.Parse(Console.ReadLine());
        //string firstPath = Console.ReadLine();
        //string secondPath = Console.ReadLine();

        Console.WriteLine(FirstTask(lamps));
        //Console.WriteLine(SecondTask(firstPath));
        //Console.WriteLine(SecondTask(secondPath));
    }
}
