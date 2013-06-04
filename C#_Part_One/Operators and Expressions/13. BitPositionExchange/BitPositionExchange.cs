//Task 13. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitPositionExchange
{
    static void Main()
    {

        Console.WriteLine("Enter a positive integer: ");
        uint i = uint.Parse(Console.ReadLine());

        string binaryValue = Convert.ToString(i, 2).PadLeft(32, '0');
        Console.WriteLine("The number you have entered has a binary representation of: \n{0}", binaryValue);

        int mask = 7; //The binary representation of 7 is: 0000 0000 0000 0000 0000 0000 0000 0111

        uint firstGroup = (uint)(mask << 3) & i; //Applying mask on bits 3,4,5
        uint secondGroup = (uint)(mask << 24) & i; //Applying mask on bits 24, 25,26

        firstGroup = firstGroup << 21; //Moving the first group of bits with 21 positions to the left
        secondGroup = secondGroup >> 21; //Moving the second group of bits with 21 positions to the right


        i = (uint)(i & (~(mask << 3))); //Change the value of first group to 0
        i = (uint)(i & (~(mask << 24))); //Change the value of second group to 0

        i = (uint)(i | firstGroup); 
        i = (uint)(i | secondGroup);

        Console.WriteLine("The binary representation of the number with exchanged bits is:\n" + Convert.ToString(i, 2).PadLeft(32, '0'));
    }
}
