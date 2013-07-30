/*Task 02. Write a method GetMax() with two parameters that returns the bigger of two integers.
 Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/

using System;

class GetMax
{
    public static int Max(int first, int second)
    {
        int result = Math.Max(first, second);

        return result;
    }

    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int result = Max(first, second);
        result = Max(result, third);

        Console.WriteLine(result);

    }
}
