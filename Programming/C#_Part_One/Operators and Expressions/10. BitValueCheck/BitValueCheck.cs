/*Task 10. Write a boolean expression that returns if the bit at position p (counting from 0) 
 in a given integer number v has value of 1. Example: v=5; p=1 -> false.*/

using System;

class BitValueCheck
{
    static void Main()
    {
        Console.WriteLine("Enter the number you would like to check: ");
        int valueToCheck = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the position of the bit: "); 
        int bitPosition = int.Parse(Console.ReadLine());

        string binaryValue = Convert.ToString(valueToCheck, 2).PadLeft(32, '0');
        Console.WriteLine("The number you have entered has a binary representation of: \n{0}", binaryValue);

        int bitToCheck = bitPosition;
        int mask = 1 << bitToCheck;
        int bitValue = valueToCheck & mask;
        bool result = (bitValue != 0);
        Console.WriteLine("Is the bit value 1? \n{0}", result);
    }
}

