/*Task 04. Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.*/

using System;

class TriangleSurface
{
    static double ByBaseAndHeight(double tBase, double tHeight)
    {
        return Math.Round((tBase * tHeight) / 2.0, 2);
    }

    static double HeronFormula(double tBase, double sideA, double sideB)
    {
        double sPerimeter = (tBase + sideA + sideB) / 2.0;
        return Math.Round(Math.Sqrt(sPerimeter * (sPerimeter - tBase) * (sPerimeter - sideA) * (sPerimeter - sideB)), 2);
    }

    static double BySideAndAngle(double sideA, double sideB, double angle)
    {
        angle = Math.Sin(angle * (2.0 * Math.PI / 360.0));
        return Math.Round((sideA * sideB * angle)/2.0, 2);
    }

    static void Main()
    {
        double tBase = 5;
        double tHeight = 3;
        double sideA = 6;
        double sideB = 7;
        double angle = 39;

        Console.WriteLine("Surface by base and height is: {0} cm^2", ByBaseAndHeight(tBase, tHeight));
        Console.WriteLine("Surface by Heron's formula is: {0} cm^2", HeronFormula(tBase, sideA, sideB));
        Console.WriteLine("Surface by sides and angle: {0} cm^2", BySideAndAngle(sideA, sideB, angle));

    }

}
