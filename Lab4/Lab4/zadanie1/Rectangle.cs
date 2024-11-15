using System;

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a rectangle at position ({X}, {Y}) with dimensions {Width}x{Height}");
    }
}