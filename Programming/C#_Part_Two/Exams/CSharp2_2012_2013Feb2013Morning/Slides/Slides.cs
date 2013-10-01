using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;

class Ball
{
    public int width { get; set; }

    public int height { get; set; }

    public int depth { get; set; }

    public Ball(int width, int height, int depth)
    {
        this.width = width;
        this.height = height;
        this.depth = depth;
    }
}

class Slides
{
    private static int cWidth, cDepth, cHeight;
    private static string[, ,] cube;
    private static Ball cubeBall;


    static void Main()
    {
#if DEBUG
        Console.SetIn(new StreamReader("../../input.txt"));
#endif

        string[] inputCoordinates = Console.ReadLine().Split(' ');
        cWidth = int.Parse(inputCoordinates[0]);
        cHeight = int.Parse(inputCoordinates[1]);
        cDepth = int.Parse(inputCoordinates[2]);

        cube = new string[cWidth, cHeight, cDepth];


        for (int height = 0; height < cHeight; height++)
        {
            string[] type = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            for (int depth = 0; depth < cDepth; depth++)
            {
                string[] instruction = type[depth].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                for (int width = 0; width < cWidth; width++)
                {
                    cube[width, height, depth] = instruction[width];
                }
            }
        }

        string ballCoordinates = Console.ReadLine();
        var ballActual = Array.ConvertAll(ballCoordinates.Split(' '), int.Parse);

        cubeBall = new Ball(ballActual[0], 0, ballActual[1]);

        RunThrough();


    }
    private static void RunThrough()
    {
        while (true)
        {
            string currCell
                = cube[cubeBall.width, cubeBall.height, cubeBall.depth];

            string[] splitedCell = currCell.Split();

            string command = splitedCell[0];

            switch (command)
            {
                case "S":
                    ProccessBallSlides(splitedCell[1]);
                    break;
                case "T":
                    cubeBall.width = int.Parse(splitedCell[1]);
                    cubeBall.depth = int.Parse(splitedCell[2]);
                    break;
                case "B":
                    PrintMessage();
                    return;
                case "E":
                    if (cubeBall.height == cHeight - 1)
                    {
                        PrintMessage();
                        return;
                    }
                    else
                    {
                        cubeBall.height++;
                    }
                    break;
                default: throw new ArgumentException("Invalid command");
            }

        }
    }

    private static void ProccessBallSlides(string command)
    {
        Ball newCubeBall = new Ball(cubeBall.width, cubeBall.height, cubeBall.depth);

        switch (command)
        {
            case "R":
                newCubeBall.height++;
                newCubeBall.width++;
                break;
            case "L":
                newCubeBall.width--;
                newCubeBall.height++;
                break;
            case "F":
                newCubeBall.depth--;
                newCubeBall.height++;
                break;
            case "B":
                newCubeBall.depth++;
                newCubeBall.height++;
                break;
            case "FL":
                newCubeBall.depth--;
                newCubeBall.width--;
                newCubeBall.height++;
                break;
            case "FR":
                newCubeBall.depth--;
                newCubeBall.width++;
                newCubeBall.height++;
                break;
            case "BL":
                newCubeBall.depth++;
                newCubeBall.width--;
                newCubeBall.height++;
                break;
            case "BR":
                newCubeBall.depth++;
                newCubeBall.width++;
                newCubeBall.height++;
                break;
            default:
                throw new ArgumentException("Ivalid slide command");
        }

        if (IsPassable(newCubeBall))
        {
            cubeBall = new Ball(newCubeBall.width, newCubeBall.height, newCubeBall.depth);
        }
        else
        {
            PrintMessage();
            Environment.Exit(0);
        }
    }

    private static void PrintMessage()
    {
        string currentCell =
            cube[cubeBall.width, cubeBall.height, cubeBall.depth];


        if (currentCell == "B"
            || cubeBall.height != cHeight - 1)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }

        Console.WriteLine("{0} {1} {2}",
            cubeBall.width,
            cubeBall.height,
            cubeBall.depth);
    }

    static bool IsPassable(Ball ball)
    {
        if (ball.width >= 0 &&
            ball.height >= 0 &&
            ball.depth >= 0 &&
            ball.width < cWidth &&
            ball.height < cHeight &&
            ball.depth < cDepth)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}
