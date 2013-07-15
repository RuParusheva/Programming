/*Task. 05 Write program that asks for a digit and depending on the input shows 
the name of that digit (in English) using a switch statement.*/

using System;

class DigitName
{
    static void Main()
    {
        Console.Write("Enter a digit (0-9): ");
        byte digit;
        bool isParsed = byte.TryParse(Console.ReadLine(), out digit);

        if (isParsed && digit > 0)
        {
            switch (digit)
            {
                case 0:
                    Console.WriteLine("I am zero ^_^");
                    break;
                case 1:
                    Console.WriteLine("I am one ^_^");
                    break;
                case 2:
                    Console.WriteLine("I am two ^_^");
                    break;
                case 3:
                    Console.WriteLine("I am three ^_^");
                    break;
                case 4:
                    Console.WriteLine("I am four ^_^");
                    break;
                case 5:
                    Console.WriteLine("I am five ^_^");
                    break;
                case 6:
                    Console.WriteLine("I am six ^_^");
                    break;
                case 7:
                    Console.WriteLine("I am seven ^_^");
                    break;
                case 8:
                    Console.WriteLine("I am eight ^_^");
                    break;
                case 9:
                    Console.WriteLine("I am nine ^_^");
                    break;
                default:
                    Console.WriteLine("My value is out of scope for this program. Enter a digit between 0-9.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid format! Please try again! ");
        }

    }
}

