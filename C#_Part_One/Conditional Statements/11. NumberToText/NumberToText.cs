/*Task 11. * Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
Examples:
0 -> "Zero"
273 ->"Two hundred seventy three"
400 -> "Four hundred"
501 -> "Five hundred and one"
711 -> "Seven hundred and eleven"*/

using System;
using System.Collections;

class NumberToText
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        uint userInput;
        bool isParsed = uint.TryParse(Console.ReadLine(), out userInput);

        string[] exceptions = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        string[] tens = { "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        string text = "";

        if (isParsed)
        {
            if (userInput == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (userInput > 999)
            {
                Console.WriteLine("You are trying to convert a value which exceeds 999. Please try a different number. ");
            }
            else
            {
                if (userInput > 99 && userInput < 1000)
                {
                    if (userInput % 100 == 0)
                    {
                        uint result = userInput / 100;
                        text = text + exceptions[result - 1] + " hundred ";
                    }
                    else if (userInput % 100 == 0 && userInput % 10 == 0)
                    {
                        uint result = userInput / 100;
                        uint resultOne = userInput / 10;
                        text = text + exceptions[result - 1] + " hundred " + tens[resultOne - 1];
                    }
                    else
                    {
                        Console.WriteLine("blank");
                    }
                }

                else if (userInput > 19 && userInput < 100)
                {
                    uint result = userInput / 10;
                    text = text + tens[result - 1] + " ";
                    userInput = userInput % 10;
                }

                if (userInput > 0 && userInput< 20)
                {
                    text = text + exceptions[userInput - 1];
                }
                Console.WriteLine(text);
            }
        }
        else
        {
            Console.WriteLine("You have entered a value which is not in scope for this program. Try again! ");
        }
    }
}
