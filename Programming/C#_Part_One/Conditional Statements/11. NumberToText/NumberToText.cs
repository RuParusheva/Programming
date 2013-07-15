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
        uint userInput = 0;
        bool isParsed = uint.TryParse(Console.ReadLine(), out userInput);

        string[] ones = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        string[] exceptions = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        string[] tens = { "", "", "Twenty ", "Thirty ", "Fourty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };

        string text = "";

        if (isParsed && userInput>= 0 && userInput < 1000)
        {

            uint modulo = userInput % 10;
            uint divisibleByTen = (userInput / 10) % 10;
            uint divisibleByHundred = (userInput / 100) % 10;

            if (divisibleByHundred != 0)
            {
              text = text + ones[divisibleByHundred] + " hundred ";

                if (divisibleByTen != 0 && divisibleByTen!= 1 && userInput>= 20)
                {
                    text = text + "and " + tens[divisibleByTen];

                    if (modulo != 0)
                    {
                        text = text + ones[modulo];
                    }
                }
                else if (divisibleByTen == 1)
                {
                    text = text + "and " + exceptions[modulo];
                }
                else
                {
                    if (modulo != 0)
                    {
                       text = text + "and " + ones[modulo];
                    }
                }
            }
            else
            {
                if (divisibleByTen != 0 && divisibleByTen != 1 && userInput >= 20)
                {
                    text = text + tens[divisibleByTen] + ones[modulo];
                }
                else if (divisibleByTen == 1)
                {
                    text = text + exceptions[modulo];
                }
                else
                {
                    text = text + ones[modulo];
                }

            }
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine("You have entered a value which is not in scope for this program. Try again! ");
        }
    }
}
