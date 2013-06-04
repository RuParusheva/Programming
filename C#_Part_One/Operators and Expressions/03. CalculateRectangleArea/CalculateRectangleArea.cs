//Task 03. Write an expression that calculates rectangle’s area by given width and height.

using System;
using System.Globalization;

class CalculateRectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle height: ");
        decimal rectangleHeight = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter rectangle width: ");
        decimal rectangleWidth = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        decimal rectangleArea = rectangleHeight * rectangleWidth;
        Console.WriteLine("The area of a triangle with the given values is: {0} ", rectangleArea);
    }
}

