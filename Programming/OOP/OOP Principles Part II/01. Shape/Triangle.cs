using System;

public class Triangle: Shape
{
    public Triangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public override double CalcSurface()
    {
        return ((Height * Width)/2);
    }
}
