using System;

class FirTree
{
    static void Main()
    {
        int inputValue = int.Parse(Console.ReadLine());

        int dots = inputValue - 2;
        int stars = 3;

        string line = new string('.', inputValue - 2) + "*" + new string('.', inputValue - 2);

        Console.WriteLine(line);

        dots--;

        for (int i = 0; i < inputValue - 2; i++)
        {
            Console.Write(new string('.', dots));
            Console.Write(new string('*', stars));
            Console.Write(new string('.', dots));
            Console.WriteLine();
            dots--;
            stars+= 2;
        }
        Console.WriteLine(line);
    }
}

