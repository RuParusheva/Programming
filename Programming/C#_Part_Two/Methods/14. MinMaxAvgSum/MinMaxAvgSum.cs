/*Task 14. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.*/

using System;
using System.Collections.Generic;

class MinMaxAvgSum
{
    public static double Average<T>(params T[] array)
    {
        double count = array.Length;

        double result = (dynamic)Sum(array) / count;

        return result;
    }

    public static T Sum<T>(params T[] array)
    {
        T sum = (dynamic)0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += (dynamic)array[i];
        }

        return sum;
    }

    public static T Max<T>(params T[] array)
        where T : IComparable<T>
    {
        int max = 0;

        for (int i = 0 + 1; i < array.Length; i++)
        {
            if (array[max].CompareTo(array[i]) < 0)
            {
                max = i;
            }
        }

        return array[max];
    }

    public static T Min<T>(params T[] array)
        where T : IComparable<T>
    {
        int min = 0;

        for (int i = 0 + 1; i < array.Length; i++)
        {
            if (array[min].CompareTo(array[i]) > 0)
            {
                min = i;
            }
        }

        return array[min];
    }

    public static T Product<T>(params T[] array)
    {
        T result = (dynamic)1;

        for (int i = 0; i < array.Length; i++)
        {
            result *= (dynamic)array[i];
        }

        return result;
    }

    static void Main()
    {
        var arrayInt = new[] { 1, 2, 3, 4, 5 };
        Console.WriteLine(Sum(arrayInt));
        Console.WriteLine(Average(arrayInt));
        Console.WriteLine(Max(arrayInt));
        Console.WriteLine(Min(arrayInt));
        Console.WriteLine(Product(arrayInt));

        Console.WriteLine();

        var arrayDouble = new[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
        Console.WriteLine(Sum(arrayDouble));
        Console.WriteLine(Average(arrayDouble));
        Console.WriteLine(Max(arrayDouble));
        Console.WriteLine(Min(arrayDouble));
        Console.WriteLine(Product(arrayDouble));
    }
}
