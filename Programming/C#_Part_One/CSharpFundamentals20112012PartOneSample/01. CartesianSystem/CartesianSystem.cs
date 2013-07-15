using System;

class CartesianSystem
{
    static void Main()
    {
        string numberX = Console.ReadLine();
        decimal numberXMod = Convert.ToDecimal(numberX);

        string numberY = Console.ReadLine();
        decimal numberYMod = Convert.ToDecimal(numberY);

        if (numberXMod == 0 && numberYMod == 0)
        {
            Console.WriteLine("0");
        }
        else if (numberXMod > 0 && numberYMod > 0)
        { 
            Console.WriteLine("1");
        }
        else if (numberYMod > 0 && numberXMod < 0)
        {
            Console.WriteLine("2");
        }
        else if (numberYMod < 0 && numberXMod < 0)
        {
            Console.WriteLine("3");
        }
        else if (numberYMod < 0 && numberXMod > 0)
        {
            Console.WriteLine("4");
        }
        else if (numberXMod == 0)
        {
            Console.WriteLine("5");
        }
        else
        {
            Console.WriteLine("6");
        }
    }
}

