using System;

public class Line
{
    public Point Start { get; set; }
    public Point End { get; set; }

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    public void Move(double deltaX, double deltaY)
    {
        Start.Move(deltaX, deltaY);
        End.Move(deltaX, deltaY);
    }

    public void Rotate(double angleInDegrees)
    {
        Start.Rotate(angleInDegrees);
        End.Rotate(angleInDegrees);
    }
}
