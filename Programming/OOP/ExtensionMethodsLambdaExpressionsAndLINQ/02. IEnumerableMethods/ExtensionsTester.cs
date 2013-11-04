/*Task 02. Implement a set of extension methods for IEnumerable<T> that implement the following 
group functions: sum, product, min, max, average.*/

using System;
using System.Collections.Generic;

class ExtensionsTester
{
    private static void Main()
    {
        var collection = new List<decimal> { 17, 1, 15, 99, 6, 7, 3 };

        Console.WriteLine(collection.Max());
        Console.WriteLine(collection.Min());
        Console.WriteLine(collection.Sum());
        Console.WriteLine(collection.Product());
        Console.WriteLine(collection.Average());
    }
}