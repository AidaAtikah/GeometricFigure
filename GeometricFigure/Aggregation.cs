using System;
using System.Collections.Generic;

public class Aggregation
{
    private List<object> figures = new List<object>();

    public void AddFigure(object figure)
    {
        figures.Add(figure);
    }

    public void Move(double deltaX, double deltaY)
    {
        foreach (var figure in figures)
        {
            if (figure is Point point)
            {
                point.Move(deltaX, deltaY);
            }
            else if (figure is Line line)
            {
                line.Move(deltaX, deltaY);
            }
            else if (figure is Circle circle)
            {
                circle.Move(deltaX, deltaY);
            }
        }
    }

    public void Rotate(double angleInDegrees)
    {
        foreach (var figure in figures)
        {
            if (figure is Point point || figure is Circle circle)
            {
                // Points and circles don't change orientation when rotated.
                continue;
            }
            else if (figure is Line line)
            {
                line.Rotate(angleInDegrees);
            }
        }
    }
}
