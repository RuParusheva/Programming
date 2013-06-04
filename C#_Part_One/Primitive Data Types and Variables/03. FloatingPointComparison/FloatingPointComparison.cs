/*Task 03. Write a program that safely compares floating-point numbers with precision of 0.000001.
Examples:(5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true*/

using System;
using System.Globalization;

class FloatingPointComparison
{
    static void Main()
    {
        //InvariantCulture will ignore your regional settings, especially useful if you are using a different separator type
        Console.WriteLine("Enter first value: ");
        decimal firstValue = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Enter second value: ");
        decimal secondValue = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        bool comparedValue = (Math.Abs(firstValue - secondValue) < 0.000001m);
        if (comparedValue == true)
        {
            Console.WriteLine("Values are equal within the required precision!");
        }
        else
        {
            Console.WriteLine("Values are not equal!");
        }
    }
}

