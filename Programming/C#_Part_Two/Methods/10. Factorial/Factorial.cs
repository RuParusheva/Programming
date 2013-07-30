/*Task 10. Write a program to calculate n! for each n in the range [1..100]. 
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.*/

using System;
using System.Collections.Generic;

class Factorial
{
    static string GetFactorial(int n)
    {
        var result = new byte[] { 1 };

        for (byte i = 2; i <= n; i++)
        {
            result = Multiply(result, i);

            //Console.WriteLine(i + ": " + string.Join(" ", result));
        }

        return string.Concat(result);
    }

    static byte[] Multiply(byte[] array, byte number)
    {
        var result = new List<byte>();

        byte carry = 0;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            long calculation = array[i] * number + carry;
            result.Add((byte)(calculation % 10));
            carry = (byte)(calculation / 10);
        }

        for (; carry != 0; carry /= 10)
        {
            result.Add((byte)(carry % 10));
        }

        result.Reverse();
        return result.ToArray();
    }

    static void Main()
    {
        checked
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("{0}: {1}", i, GetFactorial(i));
            }
        }
    }
}
