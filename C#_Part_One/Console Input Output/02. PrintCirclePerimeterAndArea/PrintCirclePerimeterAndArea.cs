//Task 02. Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;
using System.Globalization;

class PrintCirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter circle radius: ");
        decimal cRadius = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        decimal piNumber = 3.14m;

        decimal cDiameter = cRadius * 2;

        decimal cArea = piNumber * (cRadius * cRadius);

        Console.WriteLine("Circle with radius of {0} has diameter of {1} and area, which equals {2}.", cRadius, cDiameter, cArea);
    }
}

