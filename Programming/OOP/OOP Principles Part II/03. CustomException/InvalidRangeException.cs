using System;

public class InvalidRangeException<T>: Exception
{
    private const string Notification = "Value is out of range!";

    public T Start { get; private set; }
    public T End { get; private set; }

    public InvalidRangeException(T start, T end, Exception innerException = null)
        : base(Notification, innerException)
    {
        this.Start = start;
        this.End = end;
    }
}
