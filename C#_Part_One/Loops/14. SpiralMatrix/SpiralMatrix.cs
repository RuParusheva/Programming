/* Task 14. Write a program that reads a positive integer number N (N < 20) from console and outputs in the console 
the numbers 1 ... N numbers arranged as a spiral.
Example for N = 4 
 1  2  3  4
 12 13 14 5
 11 16 15 6
 10 9  8  7 */

using System;

class SpiralMatrix
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
                modifiedValue = -1 * modifiedValue/ value;

                for (int i = 0; i < count; i++)
                {
                    sum += modifiedValue;
                    valuesArray[sum / value, sum % value] = position++;
                }
                modifiedValue *= value;
                count--;

                for (int i = 0; i < count; i++)
                {
                    sum += modifiedValue;
                    valuesArray[sum / value, sum % value] = position++;
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

