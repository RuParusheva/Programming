/*Task 11. * Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
Examples:
0 -> "Zero"
273 ->"Two hundred seventy three"
400 -> "Four hundred"
501 -> "Five hundred and one"
711 -> "Seven hundred and eleven"*/

using System;

class NumberToText
{
    static void Main()
    {
        int[] set = new int[1000];

        int counter = 0;

        for (int i = 0; i < 1000; i++)
        {
            Console.Write("Enter integer number: ");
            set[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
