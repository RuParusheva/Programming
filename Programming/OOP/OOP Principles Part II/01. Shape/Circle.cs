using System;

public class Circle: Shape
{
    public Circle(double width)
    {
        this.Height = width;
        this.Width = width;
    }

    public override double CalcSurface()
    {
        return (Math.PI*(Width/2 *Width/2));
    }
}
