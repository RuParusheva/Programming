using System;

public abstract class Shape
{
    private double height;
    private double width;

    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public abstract double CalcSurface();

    public override string ToString()
    {
        return string.Format("I am a {0} and my surface is {1}.", this.GetType(), this.CalcSurface());
    }
}
