/*Task 11. Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
 percentage and in scientific notation. Format the output aligned right in 15 symbols.*/

using System;

class FormatNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Decimal: {0,15:D}; Hexadecimal: {1,15:X}; Percentage: {2,15:P}; Scientific: {3,15:E} ",
            number, number, number, number);
    }
}
