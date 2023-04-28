namespace Prototype;

public class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }

    public override Shape Clone()
    {
        return new Circle(Radius);
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a circle with radius {Radius}");
    }
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override Shape Clone()
    {
        return new Rectangle(Width, Height);
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a rectangle with width {Width} and height {Height}");
    }
}