//Task 14. Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class RandomBitPositionExchange
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer to work with:");
        uint number = uint.Parse(Console.ReadLine());

        string binaryvalue = Convert.ToString(number, 2).PadLeft(32, '0');
        Console.WriteLine("The binary representation of your number is {0}", binaryvalue);

        Console.WriteLine("Enter the first bit position you would like to work with: ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second bit position you would like to work with:");
        int q = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter how many bits would you like to change: ");
        int k = int.Parse(Console.ReadLine());

        int mask = 1;

        for (int i = 1; i < k; i++)
        {
            mask = (mask << 1) + 1;
        }

        int firstGroup = mask << p;
        int secondGroup = mask << q;

        int modifiedNumber = Convert.ToInt32(number & ~firstGroup & ~secondGroup);
        firstGroup = Convert.ToInt32((number & firstGroup) >> p);
        secondGroup = Convert.ToInt32(number & secondGroup) >> q;
        firstGroup = firstGroup << q;
        secondGroup = secondGroup << p;
        number = (uint)(modifiedNumber | firstGroup | secondGroup);

        string binaryResult = Convert.ToString(number, 2).PadLeft(32, '0');
        Console.WriteLine("The new value is {0} and it's binary representation is \n{1}", number, binaryResult);
    }
}
    

