/* Task 01.D. Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
 1 12 11 10
 2 13 16 9
 3 14 15 8
 4 5  6  7 */

using System;

class MatrixOutputD
{
    static void Main()
    {
        Console.Write("Enter number you would like a matrix for (N < 20): ");
        int userInput = 0;
        bool isParsed = int.TryParse(Console.ReadLine(), out userInput);
        int value = Convert.ToInt32(userInput);

        int[,] valuesArray = new int[value, value];

        int position = 1;
        int count = value;
        int modifiedValue = -value;
        int sum = -1;

        if (isParsed && value <= 20 && value > 0)
        {
            do
            {
                modifiedValue = -1 * modifiedValue / value;

                for (int i = 0; i < count; i++)
                {
                    sum += modifiedValue;
                    valuesArray[sum % value, sum / value] = position++;
                }
                modifiedValue *= value;
                count--;

                for (int i = 0; i < count; i++)
                {
                    sum += modifiedValue;
                    valuesArray[sum % value, sum / value] = position++;
                }
            } while (count > 0);

            //this variable adjusts alignment of matrix
            int alignment = (valuesArray.GetLength(0) * valuesArray.GetLength(1) - 1).ToString().Length + 1;

            for (int rows = 0; rows < valuesArray.GetLength(0); rows++)
            {
                for (int columns = 0; columns < valuesArray.GetLength(1); columns++)
                {
                    //using variable alignment to print out each char symmetrically and with spacing
                    Console.Write(valuesArray[rows, columns].ToString().PadLeft(alignment, ' '));
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Value is out of scope for this program. Try a different entry. ");
        }
    }
}

