/*Task 05. Write a program that reads a text file containing a square matrix of numbers and finds in the 
 matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file
 contains the size of matrix N. Each of the next N lines contain N numbers separated by space. 
 The output should be a single number in a separate text file. Example:
4
2 3 3 4
0 2 3 4 --> 17;
3 7 1 2
4 3 3 2
*/

using System;
using System.IO;

class MatrixSum
{
    static int MaximalSumOfTwo(int[,] matrix, int n)
    {
        int bestSum = int.MinValue;
        int bestSumRow = 0;
        int bestSumCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - n + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - n + 1; col++)
            {
                int currentSum = 0;

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

        return bestSum;
    }
    
    static void Main()
    {
        using (var reader = new StreamReader("../../MatrixGenerator.txt"))
        {
            int matrixSize = int.Parse(reader.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                string[] line = reader.ReadLine().Split(' ');

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = int.Parse(line[col]); 
                }
            }

            Console.WriteLine(MaximalSumOfTwo(matrix, 2));
            
        }

    }
}
