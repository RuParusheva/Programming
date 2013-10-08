using System;
using System.Collections.Generic;

public class Path
{
    private readonly List<Point> sequence = new List<Point>();

    public Path(params Point[] points)
    {
        this.sequence.AddRange(points);
    }

    public void AddPoint(Point point)
    {
       sequence.Add(point);
    }
    public override string ToString()
    {
        return string.Join(Environment.NewLine, sequence);
    }
}