using System;
using System.Globalization;

class CalculateTrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter trapezoid first base value: ");
        double baseOne = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter trapezoid second base value: ");
        double baseTwo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter trapezoid height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double area = ((baseOne + baseTwo) / 2) * height;
        Console.WriteLine("Trapezoid area is {0}", area);
    }
}

