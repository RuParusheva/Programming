/*Task 11. Write an expression that extracts from a given integer i the value of a given bit number b. 
Example: i=5; b=2 -> value=1.*/

using System;
using System.Collections;

class BitValueExtract
{
    static void Main()
    {
        Console.WriteLine("Enter the number you would like to check: ");
        int i = int.Parse(Console.ReadLine());

        Console.WriteLine("Which bit position would you like to check? ");
        int b = int.Parse(Console.ReadLine());

        string binaryValue = Convert.ToString(i, 2).PadLeft(32, '0');
        Console.WriteLine("The number you have entered has a binary representation of: \n{0}", binaryValue);

        int position = b;
        int mask = 1 << position;
        int bitValue = i & mask;
        if (bitValue == 0)
        {
            Console.WriteLine("The bit you have chosen has a value of 0."); 
        }
        else
        {
            Console.WriteLine("The bit you have chosen has a value of 1.");
        }
    }
}

