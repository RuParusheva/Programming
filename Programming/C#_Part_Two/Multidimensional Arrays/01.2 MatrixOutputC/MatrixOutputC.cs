/*Task 01.C. Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4):
 7 11 14 16
 4  8 12 15
 2  5 9  13
 1  3 6  10 */

using System;
using System.Collections.Generic;

class MatrixOutputC
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

        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            int currentRow = row;
            int currentCol = 0;

            for (int i = 0; i <= matrix.GetLength(0) - 1 - row; i++)
            {
                matrix[currentRow, currentCol] = counter++;

                currentCol++;
                currentRow++;
            }
        }
        for (int col = 1; col < matrix.GetLength(1); col++)
        {
            int currentRow = 0;
            int currentCol = col;

            for (int i = matrix.GetLength(0) - 1 - col; i >= 0 ; i--)
            {
                matrix[currentRow, currentCol] = counter++;

                currentCol++;
                currentRow++;
            }
        }
        Print(matrix);
    }
}
