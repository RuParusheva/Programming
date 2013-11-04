/*Task 06. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.*/
using System;
using System.Collections.Generic;
using System.Linq;

class DivisibleBy21
{
    static void Main()
    {
        var numbers = new[]{11, 45, 3, 21, 42, 17, 63, 55, 99, 0};

        Print(numbers.Where(x => x % 21 == 0));
        Print(
            from x in numbers
            where x % 21 == 0
            select x
        );
    }

    static void Print<T>(IEnumerable<T> elements)
    {
        Console.WriteLine(string.Join(" ", elements));
    }
}
