using System;

public class Circle
{
    public Point Center { get; set; }
    public double Radius { get; set; }

    public Circle(Point center, double radius)
    {
        Center = center;
        Radius = radius;
    }

    public void Move(double deltaX, double deltaY)
    {
        Center.Move(deltaX, deltaY);
    }

    public void Rotate(double angleInDegrees)
    {
        // Circles don't change orientation when rotated.
    }
}
