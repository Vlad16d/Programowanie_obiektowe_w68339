using System;
public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a triangle at position ({X}, {Y}) with base {Width} and height {Height}");
    }
}