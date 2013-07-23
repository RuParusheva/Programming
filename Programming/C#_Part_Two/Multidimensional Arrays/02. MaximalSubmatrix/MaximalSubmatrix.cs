/*Task 02. Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
that has maximal sum of its elements.*/


using System;
using System.Collections.Generic;

class MaximalSubmatrix
{
    static void Main()
    {
        int[,] matrix = {
            {11, 4, 6, 5, 232},
            {6, 90, 15, 8, -1},
            {-3, -17, 8, 0, 6},
            {61, 920, 215, 48, -51},
        };

        int bestSum = int.MinValue;
        int bestSumRow = 0;
        int bestSumCol = 0;

        int n = 3;

        for (int row = 0; row < matrix.GetLength(0) - n + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - n + 1; col++)
            {
                //int currentSum =
                //    matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                //    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                //    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                int currentSum = 0;

                //Console.WriteLine(row + " " + col);

                for (int currentRow = row; currentRow < row + n; currentRow++)
                {
                    for (int currentCol = col; currentCol < col + n; currentCol++)
                    {
                        currentSum += matrix[currentRow, currentCol];
                    }
                }

                if (currentSum >= bestSum)
                {
                    bestSum = currentSum;
                    bestSumRow = row;
                    bestSumCol = col;
                }
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 3} ", matrix[bestSumRow + row, bestSumCol + col]);
            }

            Console.WriteLine();
        }

        Console.WriteLine(bestSum);
        //Console.WriteLine(bestSumRow + " " + bestSumCol);
    }
}
