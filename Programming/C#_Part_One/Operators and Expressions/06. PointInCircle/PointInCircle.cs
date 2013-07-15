//Task 06. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;
using System.Globalization;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter centerpoint X-axis: ");
        double xAxis = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter centerpoint Y-axis: ");
        double yAxis = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter circle radius: ");
        double cRadius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter X-axis of the point you wish to check");
        double pointXAxis = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter Y-axis of the point you wish to check");
        double pointYAxis = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double distance = Math.Sqrt((pointXAxis - xAxis) * (pointXAxis - xAxis) + (pointYAxis - yAxis) * (pointYAxis - yAxis));

        Console.WriteLine("The distance between the point and center of the circle is: {0}", distance);

        if (distance <= cRadius)
        {
            Console.WriteLine("The point is within the circle");
        }
        else
        {
            Console.WriteLine("The point is outside the circle");
        }
    }
}

