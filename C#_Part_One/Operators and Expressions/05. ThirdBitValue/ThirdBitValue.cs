//Task 05. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class ThirdBitValue
{
    static void Main()
    {
        Console.WriteLine("Enter a number you would like to check: ");
        int valueToCheck = int.Parse(Console.ReadLine());

        string binaryValue = Convert.ToString(valueToCheck, 2).PadLeft(32, '0');
        Console.WriteLine("The number you have entered has a binary representation of: \n{0}", binaryValue);

        Console.WriteLine("Counting from zero to three (right to left), bit 3 is located at position 4.");

        int bitToCheck = 3;
        int mask = 1 << bitToCheck;
        int bitValue = valueToCheck & mask;
        if (bitValue == 0)
        {
            Console.WriteLine("Bit 3 for the number you have chosen has a value of 0.");
        }
        else
        {
            Console.WriteLine("Bit 3 for the number you have chosen has a value of 1.");
        }
    }
}

