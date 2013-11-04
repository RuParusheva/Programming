using System;

internal class Rectangle : Shape
{
    public Rectangle(double height, double width )
    {  
        this.Height = height;
        this.Width = width;
    }

    public override double CalcSurface()
    {
        return (Height*Width);
    }

}
