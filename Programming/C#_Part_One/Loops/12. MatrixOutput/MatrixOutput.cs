/*Task 12. Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix 
 like the following:
N = 3	N = 4
 123    1234
 234    2345
 345    3456
        4567 */

using System;

class MatrixOutput
{
    static void Main()
    {
        Console.Write("Enter number you would like a matrix for (N < 20): ");
        uint userInput = 0;
        bool isParsed = uint.TryParse(Console.ReadLine(), out userInput);
        uint value = Convert.ToUInt32(userInput);

        uint[,] valuesArray = new uint[value, value];

        uint counter = 0;

        if (isParsed && value <= 20)
        {
            for (uint rows = 0; rows < valuesArray.GetLength(0); rows++)
            {
                for (uint columns = 0; columns < valuesArray.GetLength(1); columns++)
                {
                    counter++;
                    valuesArray[rows, columns] = counter;
                }
                counter = rows + 1;
            }

            //this variable adjusts alignment of matrix
            int alignment = (valuesArray.GetLength(0) * valuesArray.GetLength(1) - 1).ToString().Length + 1;

            for (int rows = 0; rows < valuesArray.GetLength(0); rows++)
            {
                for (int columns = 0; columns < valuesArray.GetLength(1); columns++)
                {
                    //using variable alignment to print out each char symmetrically and with spacing
                    Console.Write(valuesArray[rows, columns].ToString().PadLeft(alignment,' '));
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

