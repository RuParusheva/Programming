using System;

public static class Distance
{
    public static double CalculateDistance(Point p1, Point p2)
    {
        double deltaX = p2.X - p1.X;
        double deltaY = p2.Y - p1.Y;
        double deltaZ = p2.Z - p1.Z;

        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        return distance;
    }
}