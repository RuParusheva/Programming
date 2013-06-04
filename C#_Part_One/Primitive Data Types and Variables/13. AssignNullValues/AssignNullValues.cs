/*Task 13. Create a program that assigns null values to an integer and to double variables. 
Try to print them on the console, try to add some values or the null literal to them and see the result.*/

using System;
using System.Globalization;

class AssignNullValues
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number: ");
        int? firstValue = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Enter number with a floating point: ");
        double secondValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        firstValue = null;
        double? secondNull;
        secondNull = null;
        Console.WriteLine("You have entered: {0} {1} ", firstValue, secondNull);
    }
}

