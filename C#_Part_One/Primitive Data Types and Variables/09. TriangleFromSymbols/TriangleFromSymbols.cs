/*Task 09. Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
Use Windows Character Map to find the Unicode code of the © symbol. 
Note: the © symbol may be displayed incorrectly.*/

using System;
using System.Text;


class TriangleFromSymbols
{
    static void Main()
    {
        char cSymbol = '\u00a9';
        Console.OutputEncoding = Encoding.UTF8; //Changes encoding to display symbol
        int rows = 3;
        int columns = rows * 2 - 1;
        for (int i = 0; i < rows; i++)
        {
            for (int x = 0; x < columns; x++)
            {
                if ((x == columns / 2 - i) || (x == columns / 2 + i) || i == rows - 1)
                {
                    Console.Write(cSymbol);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

