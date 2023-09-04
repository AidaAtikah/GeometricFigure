using System;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void Move(double deltaX, double deltaY)
    {
        X += deltaX;
        Y += deltaY;
    }

    public void Rotate(double angleInDegrees)
    {
        double radians = angleInDegrees * (Math.PI / 180);
        double newX = X * Math.Cos(radians) - Y * Math.Sin(radians);
        double newY = X * Math.Sin(radians) + Y * Math.Cos(radians);
        X = newX;
        Y = newY;
    }
}
