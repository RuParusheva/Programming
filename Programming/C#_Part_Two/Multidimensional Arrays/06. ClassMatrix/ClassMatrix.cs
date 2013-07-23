/*Task 06. Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, subtracting 
 and multiplying of matrices, indexer for accessing the matrix content and ToString().*/

using System;
using System.Collections.Generic;
using System.Diagnostics;

class Matrix
{
    //fields
    public int[,] matrix;
    public int rows;
    public int columns;

    //this is the class constructor
    public Matrix(int i, int j)
    {
        matrix = new int[i, j];
        rows = i;
        columns = j;
    }

    // get, set
    public int this[int i, int j]
    {
        get { return this.matrix[i, j]; }
        set { this.matrix[i, j] = value; }
    }

    //1-st method
    public static Matrix operator +(Matrix first, Matrix second)
    {

        Matrix third = new Matrix(first.rows, second.columns);

        for (int rows = 0; rows < third.rows; rows++)
        {
            for (int columns = 0; columns < third.columns; columns++)
            {
                third[rows, columns] = first[rows, columns] + second[rows, columns];
            }
        }

        return third;
    }

    //2-nd method 
    public static Matrix operator -(Matrix first, Matrix second)
    {

        Matrix third = new Matrix(first.rows, second.columns);

        for (int rows = 0; rows < third.rows; rows++)
        {
            for (int columns = 0; columns < third.columns; columns++)
            {
                third[rows, columns] = first[rows, columns] - second[rows, columns];
            }
        }

        return third;
    }

    //3-rd method
    public static Matrix operator *(Matrix first, Matrix second)
    {
 //making sure first matrix columns and second matrix rows have the same length, pop-up will notify in case of mismatch
        Debug.Assert(first.columns == second.rows); 
        {
            Matrix third = new Matrix(first.rows, second.columns);

            for (int rows = 0; rows < third.columns; rows++)
            {
                for (int columns = 0; columns < first.rows; columns++)
                {
                    int value = 0;

                    for (int modifier = 0; modifier < second.rows; modifier++)
                    {
                        value += first[columns, modifier] * second[modifier, rows];
                    }
                    third[columns, rows] = value;
                }
            }
            return third;
        }
    }

    //print
    public override string ToString()
    {
        string result = string.Empty;

        for (int i = 0; i < this.rows; i++)
        {
            for (int j = 0; j < this.columns; j++)
            {
                result += this[i, j].ToString().PadLeft(6, ' ');
            }

            result += Environment.NewLine;
        }

        return result;
    }
}
class ClassMatrix
{
    static void Main()
    {
        Matrix first = new Matrix(5, 5); 
        Matrix second = new Matrix(5, 5);

        Random random = new Random();

        for (int rows = 0; rows < first.rows; rows++)
        {
            for (int columns = 0; columns < first.columns; columns++)
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
    }
}

