using System;

class Trapezoid
{
    static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());

        int outerDots = userInput - 1;
        int innerDots = userInput - 1;

        string firstLine = new string('.', userInput) + new string('*', userInput);
        string lastLine = new string('*', userInput * 2);

        Console.WriteLine(firstLine);
        for (int index = 2; index < userInput + 1; index++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write("*");
            Console.Write(new string('.', innerDots));
            Console.Write("*");
            Console.WriteLine();

            outerDots--;
            innerDots++;
        }
        Console.WriteLine(lastLine);
    }
}

