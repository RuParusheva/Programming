/*Task 03. We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several
 neighbor elements located on the same line, column or diagonal. Write a program that finds the longest 
 sequence of equal strings in the matrix. Example:
ha fifi ho hi                   s  qq s 
fo  ha  hi xx -> ha, ha, ha     pp pp s -> s, s, s
xxx ho  ha xx                   pp qq s
*/

using System;
using System.Text;

class LongestStringSequence
{
    static string maxSeq = string.Empty;
    static int maxCount = 0;

    static void Main()
    {
        string[,] matrix = {
            {"ha", "fifi", "ho", "hi"},
            {"fo", "ha", "hi", "xx"},
            {"xxx", "ho", "ha", "xx"},
          };

        /*string[,] matrix = {
            {"s", "qq", "s"},
            {"pp", "pp", "s"},
            {"pp", "qq", "s"},
        };*/

        int count = 0;

        for (int row = 0, lenRow = matrix.GetLength(0); row < lenRow; row++)
        {
            for (int col = 0, lenCol = matrix.GetLength(1); col < lenCol; col++)
            {
                string current = matrix[row, col];

                // Checking column
                if (row > 0 && matrix[row - 1, col] != current ||
                row == 0)
                {
                    count = 1;
                    for (int i = row + 1; i < lenRow; i++)
                    {
                        if (matrix[i, col] == current)
                        {
                            count++;
                        }
                    }

                    UpdateMax(count, current);
                }

                // checking row
                if (col > 0 && matrix[row, col - 1] != current ||
                col == 0)
                {
                    count = 1;
                    for (int i = col + 1; i < lenCol; i++)
                    {
                        if (matrix[row, i] == current)
                        {
                            count++;
                        }
                    }

                    UpdateMax(count, current);
                }

                // checking diagonal
                if (col < lenCol - 1)
                {
                    if (row > 0 && col > 0 && matrix[row - 1, col - 1] != current ||
                    row == 0 || col == 0)
                    {
                        count = 1;
                        int i = 1;

                        while (row + i < lenRow && col + i < lenCol)
                        {
                            if (matrix[row + i, col + i] == current)
                            {
                                count++;
                            }

                            i++;
                        }

                        UpdateMax(count, current);
                    }
                }

            }

        }

        StringBuilder sb = new StringBuilder();
        sb.Append(maxSeq);

        for (int i = 0, len = maxCount - 1; i < len; i++)
        {
            sb.Append(", ");
            sb.Append(maxSeq);
        }

        Console.WriteLine(sb);
    }

    private static void UpdateMax(int count, string current)
    {
        if (count > maxCount)
        {
            maxCount = count;
            maxSeq = current;
        }
    }
}