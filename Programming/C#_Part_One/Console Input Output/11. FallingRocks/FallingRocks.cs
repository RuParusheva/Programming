/* Task 11. Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen 
 and can move left and right (by the arrows keys). A number of rocks of different sizes and forms constantly fall down 
 and you need to avoid a crash. Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - 
 distributed with appropriate density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
 Implement collision detection and scoring system.*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


struct Rocks
{
    public int x;
    public int y;
    public object type;
    public ConsoleColor color;
}
class FallingRocks
{
    static void PrintOnPosition(int x, int y, object type, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(type);
    }

    static void PrintStringOnPosition(int x, int y, string info, ConsoleColor color = ConsoleColor.Magenta)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(info);
    }

    static void Main()
    {

        int livesCount = 4;

        int points = 0;

        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;

        Rocks dwarf = new Rocks();
        dwarf.x = Console.WindowWidth - 42;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.type = "(O)";
        dwarf.color = ConsoleColor.White;

        Random rocksRandomizer = new Random(); 

        List<Rocks> fallingSymbols = new List<Rocks>();
        
        List<string> symbolType = new List<string> {"^", "@", "+", "&", "%", "$", "!", "#", ".", ";", "*", "-"};

        while (true)
        {

            bool isCollision = false;

            Rocks newSymbol = new Rocks();

            newSymbol.x = rocksRandomizer.Next(0, Console.WindowWidth);
            newSymbol.y = 2;
            newSymbol.color = (ConsoleColor)rocksRandomizer.Next((int)ConsoleColor.DarkBlue, (int)ConsoleColor.White);
            newSymbol.type = symbolType[rocksRandomizer.Next(symbolType.Count)];

            fallingSymbols.Add(newSymbol);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo userInput = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (userInput.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }   
                }
                else if (userInput.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 < Console.WindowWidth - 3)
                    {
                        dwarf.x = dwarf.x + 1;
                    }                   
                }
            }

            List<Rocks> randomList = new List<Rocks>();

            for (int i = 0; i < fallingSymbols.Count; i++)
            {
                Rocks previousSymbol = fallingSymbols[i];
                Rocks nextSymbol = new Rocks();

                nextSymbol.x = previousSymbol.x;
                nextSymbol.y = previousSymbol.y + 1;
                nextSymbol.type = previousSymbol.type;
                nextSymbol.color = previousSymbol.color;

                if ((nextSymbol.x == dwarf.x || nextSymbol.x == dwarf.x + 1 || nextSymbol.x == dwarf.x + 2) && (nextSymbol.y == dwarf.y || nextSymbol.y == dwarf.y + 1 || nextSymbol.y == dwarf.y + 2))
                {
                    livesCount--;
                    points = points - 100;

                    isCollision = true;

                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(31, 0, "GAME OVER!!!", ConsoleColor.Red);
                        PrintStringOnPosition(28, 1, "Press [enter] to exit", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }                 
                }

                if (nextSymbol.y < Console.WindowHeight - 1)
                {
                    randomList.Add(nextSymbol);
                }              
            }

            fallingSymbols = randomList;

            Console.Clear();

            if (isCollision)
            {
                fallingSymbols.Clear();
                PrintOnPosition(dwarf.x, dwarf.y, ":( ", ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(dwarf.x, dwarf.y, dwarf.type, dwarf.color);
                points ++;
            }

            foreach (Rocks symbol in fallingSymbols)
            {
                PrintOnPosition(symbol.x, symbol.y, symbol.type, symbol.color);
            }
          
            PrintStringOnPosition(35, 0, "Lives: " + livesCount);

            PrintStringOnPosition(35, 1, "Score: " + points, ConsoleColor.Cyan); 

            Thread.Sleep(150);
        }
            
    }
}



