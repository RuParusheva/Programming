/*Task 01.B. Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4):
 1 8  9 16
 2 7 10 15
 3 6 11 14
 4 5 12 13*/

using System;

class MatrixOutputB
{
    public static void Swap(int[,] matrix)
    {
        for (int col = 1; col < matrix.GetLength(1); col += 2)
        {
            for (int row = 0; row < matrix.GetLength(0) / 2; row++)
            {
                int temp = matrix[row, col];
                matrix[row, col] = matrix[matrix.GetUpperBound(0) - row, col];
                matrix[matrix.GetUpperBound(0) - row, col] = temp;
            }
        }
    }

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

        Swap(matrix);
        Print(matrix);
    }
}
