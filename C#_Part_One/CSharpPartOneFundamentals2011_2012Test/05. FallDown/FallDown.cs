using System;

class FallDown
{
    static void Main()
    {
       
        int[,] inputValues = new int[8, 8];

        for (int rows = 0; rows < inputValues.GetLength(0); rows++)
        {
            int matrix = int.Parse(Console.ReadLine());

            for (int columns = 0; columns < inputValues.GetLength(1); columns++)
            {
                inputValues[rows, columns] = matrix % 2;
                matrix /= 2;
            }
        }

        int[] modifyInput = new int[8];

        for (int columns = 0; columns < 8; columns++)
        {
            for (int rows = 0; rows < 8; rows++)
            {
                modifyInput[rows] = inputValues[rows, columns];

            }

            Array.Sort(modifyInput);

            for (int rows = 0; rows < 8; rows++)
            {
                inputValues[rows, columns] = modifyInput[rows];
            }
        }

        for (int rows = 0; rows < inputValues.GetLength(0); rows++)
        {
            string currentRow = string.Empty;

            for (int columns = inputValues.GetLength(1) - 1; columns >= 0; columns--)
            {
                currentRow += inputValues[rows, columns];
            }
            Console.WriteLine(Convert.ToInt32(currentRow, 2));
        }
    }
}

