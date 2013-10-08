using System;
using System.Text;

public class GenericMatrix<T>
{
    //fields
    public T[,] matrix;
    private int rows;
    private int columns;

    //this is the class constructor
    public GenericMatrix(int row, int col)
    {
        if (row > 0)
        {
            this.rows = row;
        }
        else
        {
            throw new ArgumentOutOfRangeException("row");
        }
        if (col > 0)
        {
            this.columns = col;
        }
        else
        {
            throw new ArgumentOutOfRangeException("col");
        }
        matrix = new T[row, col];
    }

    public int Rows
    {
        get { return this.rows; }
    }

    public int Columns
    {
        get { return this.columns; }
    }

    // get, set
    public T this[int row, int col]
    {
        get
        {
            if (rows < row || columns < col || row < 0 || col < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return matrix[row, col];
        }
        set
        {
            if (rows < row || columns < col || row < 0 || col < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            matrix[row, col] = value;
        }
    }

    public static GenericMatrix<T> operator +(GenericMatrix<T> first, GenericMatrix<T> second)
    {
        //making sure first matrix and second matrix rows & columns have the same length, exception will be thrown in case of mismatch
        if (first.rows != second.rows || first.columns != second.columns)
        {
            throw new ArgumentException("Matrices do not have equal length");
        }

        GenericMatrix<T> third = new GenericMatrix<T>(first.rows, second.columns);

        for (int rows = 0; rows < third.rows; rows++)
        {
            for (int columns = 0; columns < third.columns; columns++)
            {
                third[rows, columns] = (dynamic)first[rows, columns] + (dynamic)second[rows, columns];
            }
        }

        return third;
    }


    public static GenericMatrix<T> operator -(GenericMatrix<T> first, GenericMatrix<T> second)
    {
        //making sure first matrix and second matrix rows & columns have the same length, exception will be thrown in case of mismatch
        if (first.rows != second.rows || first.columns != second.columns)
        {
            throw new ArgumentException("Matrices do not have equal length");
        }
        GenericMatrix<T> third = new GenericMatrix<T>(first.rows, second.columns);

        for (int rows = 0; rows < third.rows; rows++)
        {
            for (int columns = 0; columns < third.columns; columns++)
            {
                third[rows, columns] = (dynamic)first[rows, columns] - (dynamic)second[rows, columns];
            }
        }

        return third;
    }


    public static GenericMatrix<T> operator *(GenericMatrix<T> first, GenericMatrix<T> second)
    {
        //making sure first matrix columns and second matrix rows have the same length, exception will be thrown in case of mismatch
        if (first.columns != second.rows)
        {
            throw new ArgumentException("Matrices do not have equal length");
        }

        GenericMatrix<T> third = new GenericMatrix<T>(first.rows, second.columns);

        for (int rows = 0; rows < third.columns; rows++)
        {
            for (int columns = 0; columns < first.rows; columns++)
            {
                dynamic value = 0;

                for (int modifier = 0; modifier < second.rows; modifier++)
                {
                    value += (dynamic)first[columns, modifier] * (dynamic)second[modifier, rows];
                }
                third[columns, rows] = value;
            }
        }
        return third;
    }


    public static Boolean operator true(GenericMatrix<T> matrix)
    {
        for (int i = 0; i < matrix.rows; i++)
        {
            for (int j = 0; j < matrix.columns; j++)
            {
                if ((dynamic)matrix[i, j] != 0)
                {
                    return true;
                }
            }
        }
        return false;
    }


    public static Boolean operator false(GenericMatrix<T> matrix)
    {
        for (int i = 0; i < matrix.rows; i++)
        {
            for (int j = 0; j < matrix.columns; j++)
            {
                if ((dynamic)matrix[i, j] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }

    //print
    public override string ToString()
    {
        var result = new StringBuilder();

        for (int i = 0; i < this.rows; i++)
        {
            for (int j = 0; j < this.columns; j++)
            {
                result.Append(this[i, j].ToString());
            }
            result.AppendLine();
        }

        return result.ToString();
    }
}

