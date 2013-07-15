/*Task 11. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
The cards should be printed with their English names. Use nested for loops and switch-case.*/

using System;
using System.Text;

class DeckOfCards
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        char hearts = '\u2665';
        char diamonds = '\u2666';
        char clubs = '\u2663';
        char spades = '\u2660';

        for (int rank = 1; rank <= 13; rank++)
        {
            for (int suit = 1; suit <= 4; suit++)
            {
                switch (rank)
                {
                    case 1:
                        Console.Write("Ace");
                        break;
                    case 2:
                        Console.Write("Two");
                        break;
                    case 3:
                        Console.Write("Three");
                        break;
                    case 4:
                        Console.Write("Four");
                        break;
                    case 5:
                        Console.Write("Five");
                        break;
                    case 6:
                        Console.Write("Six");
                        break;
                    case 7:
                        Console.Write("Seven");
                        break;
                    case 8:
                        Console.Write("Eight");
                        break;
                    case 9:
                        Console.Write("Nine");
                        break;
                    case 10:
                        Console.Write("Ten");
                        break;
                    case 11:
                        Console.Write("Jack");
                        break;
                    case 12:
                        Console.Write("Queen");
                        break;
                    case 13:
                        Console.Write("King");
                        break;                       
                }

                switch (suit)
                {
                    case 1:
                        Console.WriteLine(" of Hearts {0}", hearts);
                        break;
                    case 2:
                        Console.WriteLine(" of Diamonds {0}", diamonds);
                        break;
                    case 3:
                        Console.WriteLine(" of Clubs {0}", clubs);
                        break;
                    case 4:
                        Console.WriteLine(" of Spades {0}", spades);
                        break;
                }
            }
        }
    }
}

