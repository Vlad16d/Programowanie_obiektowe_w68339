using System;
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a circle at position ({X}, {Y}) with diameter {Width}");
    }
}