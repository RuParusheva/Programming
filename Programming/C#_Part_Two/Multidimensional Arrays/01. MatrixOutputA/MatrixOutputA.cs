/*Task 01.A. Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4):
 1 5  9 13
 2 6 10 14
 3 7 11 15
 4 8 12 16 */

using System;

class MatrixOutputA
{
    public static void Print(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
    static void Main()
    {
        int[,] matrix = new int[4, 4];

        int counter = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = counter++;
                //matrix[row, col] = (row +1) + col*4;
            }
        }

        Print(matrix);
    }
}

