using System;
using System.Collections.Generic;

internal static class EnumerableExtensions
{
    private const string NoElementsErrorMessage = "No elements";

    public static T Max<T>(this IEnumerable<T> elements)
        where T : IComparable<T>
    {
        if (!elements.Any())
        {
            throw new ArgumentException(NoElementsErrorMessage);
        }

        T max = elements.First();

        foreach (T element in elements)
        {
            if (max.CompareTo(element) < 0)
            {
                max = element;
            }
        }

        return max;
    }

    public static T Min<T>(this IEnumerable<T> elements)
        where T : IComparable<T>
    {
        if (!elements.Any())
        {
            throw new ArgumentException(NoElementsErrorMessage);
        }

        T min = elements.First();

        foreach (T element in elements)
        {
            if (min.CompareTo(element) > 0)
            {
                min = element;
            }
        }

        return min;
    }

    public static T Sum<T>(this IEnumerable<T> elements)
    {
        if (!elements.Any())
        {
            throw new ArgumentException(NoElementsErrorMessage);
        }

        dynamic result = 0;

        checked
        {
            foreach (T element in elements)
            {
                result += element;
            }
        }

        return result;
    }

    public static T Product<T>(this IEnumerable<T> elements)
    {
        if (!elements.Any())
        {
            throw new ArgumentException(NoElementsErrorMessage);
        }

        dynamic result = 1;

        checked
        {
            foreach (T element in elements)
            {
                result *= element;
            }
        }

        return result;
    }

    public static decimal Average<T>(this IEnumerable<T> elements)
    {
        if (!elements.Any())
        {
            throw new ArgumentException(NoElementsErrorMessage);
        }

        return (dynamic) elements.Sum()/(decimal) elements.Count();
    }

    public static T First<T>(this IEnumerable<T> elements)
    {
        //var enumerator = elements.GetEnumerator();
        //bool result = enumerator.MoveNext();
        //if (result)
        //{
        //    return enumerator.Current;
        //}

        foreach (T element in elements)
        {
            return element;
        }

        throw new ArgumentException(NoElementsErrorMessage);
    }

    public static bool Any<T>(this IEnumerable<T> elements)
    {
        foreach (var element in elements)
        {
            return true;
        }
        return false;
    }

    public static int Count<T>(this IEnumerable<T> elements)
    {
        int result = 0;

        foreach (var element in elements)
        {
            result++;
        }

        return result;
    }
}