public struct Point
{
    public double X { get; private set; }
    public double Y { get; private set; }
    public double Z { get; private set; }

    private static readonly Point start = new Point(0, 0, 0);

    public static Point Start
    {
        get { return start; }
    }

    public Point(double x, double y, double z)
        : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public override string ToString()
    {
        return string.Join(",", this.X, this.Y, this.Z);
    }
}