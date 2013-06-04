/*Task 09. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
 and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

using System;
using System.Globalization;

class PointInCircleAndRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter circle centerpoint X-axis: ");
        double xAxis = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter circle centerpoint Y-axis: ");
        double yAxis = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter circle radius: ");
        double cRadius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter rectangle height: ");
        double rectangleHeight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter rectangle width: ");
        double rectangleWidth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter top triangle point: ");
        double topPoint = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter left triangle point: ");
        double leftPoint = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter X-axis of the point you wish to check:");
        double pointXAxis = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Enter Y-axis of the point you wish to check:");
        double pointYAxis = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double distance = Math.Sqrt((pointXAxis - xAxis) * (pointXAxis - xAxis) + (pointYAxis - yAxis) * (pointYAxis - yAxis));

        Console.WriteLine("The distance between the point and center of the circle is: {0}", distance);

        bool coordinateOne = pointXAxis > topPoint && pointXAxis < (topPoint + rectangleHeight);

        bool coordinateTwo = pointYAxis > leftPoint && pointYAxis < (leftPoint + rectangleWidth);

        bool statement = coordinateOne && coordinateTwo;
        
        if (distance <= cRadius && statement == true)
        {
            Console.WriteLine("The point is inside the circle and within the rectangle.");
        }
        else
        {
            Console.WriteLine("The point is outside the circle and the rectangle.");
        }
    }
}

