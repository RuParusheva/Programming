//Task 02. Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Linq;

class RandomTenFromRange
{
    
    static void Main()
    {
        Random random = new Random();

        foreach (int i in Enumerable.Range(0, 10))
        {
            Console.WriteLine(random.Next(100, 201));
        }
    }
}
