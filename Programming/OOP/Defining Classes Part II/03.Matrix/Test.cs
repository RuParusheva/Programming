/*Tasks 08-10:
08. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
09. Implement an indexer this[row, col] to access the inner matrix cells.
10. Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        GenericMatrix<int> first = new GenericMatrix<int>(5, 5);
        GenericMatrix<int> second = new GenericMatrix<int>(5, 5);

        Random random = new Random();

        for (int rows = 0; rows < first.Rows; rows++)
        {
            for (int columns = 0; columns < first.Columns; columns++)
            {
                first[rows, columns] = random.Next(-150, 150);
                second[rows, columns] = random.Next(-150, 150);
            }
        }
        Console.WriteLine("Matrix 1:");
        Console.WriteLine(first);

        Console.WriteLine("Matrix 2:");
        Console.WriteLine(second);

        Console.WriteLine("Result after addition:");
        Console.WriteLine(first + second);

        Console.WriteLine("Result upon substraction:");
        Console.WriteLine(first - second);

        Console.WriteLine("Matrices multiplication:");
        Console.WriteLine(first * second);

        if (first)
        {
            Console.WriteLine("Not empty");
        }
        else
        {
            Console.WriteLine("Empty");
        }
    }
}
