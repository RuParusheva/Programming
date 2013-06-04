using System;
using System.Text;

class EquilateralTriangle
{
    static void Main()
    {
        char cSymbol = '\u00a9';
        Console.OutputEncoding = Encoding.UTF8; //Changes encoding to display symbol
        int emptyChars = 12;

        for (int row = 0; row <= 6; row++) //This line runs all over the triangle
        {
            for (int i = 0; i < emptyChars; i++) //This changes the way triangle is displayed on the console
            {
                Console.Write(" ");
            }

            emptyChars--;

            for (int column = 0; column <= row; column++) //Draw symbols and space
            {
                Console.Write(cSymbol + " ");
            }
            Console.WriteLine(); //New line for the next sequence
        }
    }
}

