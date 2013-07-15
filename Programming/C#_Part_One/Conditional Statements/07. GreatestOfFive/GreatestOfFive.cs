//Task 07. Write a program that finds the greatest of given 5 variables.

using System;
using System.Linq;

class GreatestOfFive
{
    static void Main()
    {
        int[] value = new int[5];

        for (int i = 0; i < value.Length; i++)
        {
            Console.Write("Enter a number: ");
            value[i] = int.Parse(Console.ReadLine());
        }

        var result = from number in value
                     orderby number descending
                     select number;
        
        Console.WriteLine("The greatest number is: {0}", result.First());
    }
}
