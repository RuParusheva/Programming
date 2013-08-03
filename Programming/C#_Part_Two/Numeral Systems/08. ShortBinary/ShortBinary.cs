// Task 08. Write a program that shows the binary representation of given 16-bit signed integer number(the C# type short).

using System;
using System.Collections.Generic;

class ShortBinary
{
    static string ShortToBinary(short number)
    {
        char[] binary = new char[16];
        int position = 15;
        int index = 0;

        while (index < 16)
        {
            if ((number & (1 << index)) != 0)
            {
                binary[position] = '1';
            }
            else
            {
                binary[position] = '0';
            }
            position--;
            index++;
        }
        return new string(binary);
    }

    static void Main()
    {
        short number = -15;

        Console.WriteLine(ShortToBinary(number));
    }
}
