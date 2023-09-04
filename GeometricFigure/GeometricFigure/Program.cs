using System;

class Program
{
    static void Main()
    {
        Point point1 = new Point(1, 1);
        Point point2 = new Point(2, 2);
        Line line1 = new Line(point1, point2);
        Circle circle1 = new Circle(new Point(3, 3), 2);

        Aggregation aggregation = new Aggregation();
        aggregation.AddFigure(point1);
        aggregation.AddFigure(point2);
        aggregation.AddFigure(circle1);

        Console.WriteLine("Initial Positions:");
        Console.WriteLine($"Point 1: ({point1.X}, {point1.Y})");
        Console.WriteLine($"Point 2: ({point2.X}, {point2.Y})");
        Console.WriteLine($"Circle 1 Center: ({circle1.Center.X}, {circle1.Center.Y})");

        // Move all figures
        aggregation.Move(1, 1);

        Console.WriteLine("\nAfter Moving:");
        Console.WriteLine($"Point 1: ({point1.X}, {point1.Y})");
        Console.WriteLine($"Point 2: ({point2.X}, {point2.Y})");
        Console.WriteLine($"Circle 1 Center: ({circle1.Center.X}, {circle1.Center.Y})");

        // Rotate all figures
        aggregation.Rotate(45);

        Console.WriteLine("\nAfter Rotating:");
        Console.WriteLine($"Line 1 Start: ({line1.Start.X}, {line1.Start.Y})");
        Console.WriteLine($"Line 1 End: ({line1.End.X}, {line1.End.Y})");
        Console.WriteLine($"Circle 1 Center: ({circle1.Center.X}, {circle1.Center.Y})");

        // Wait for a key press before exiting
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();


    }
}
