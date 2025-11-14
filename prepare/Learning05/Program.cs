using System;

class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Square("Green;", 2.0);
        Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea()} ");

        Shape notSquare = new Rectangle("Red;", 3.0, 4.0);
        Console.WriteLine($"Color: {notSquare.GetColor()} Area: {notSquare.GetArea()}");

        Shape circle = new Circle("Blue;", 2.0);
        Console.WriteLine($"Color: {circle.GetColor()} Area: {circle.GetArea():F2}"); // F2 rounds the decimal to 2 decimal places 


        Console.WriteLine("------List of Shapes ------");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(shape);
        shapes.Add(notSquare);
        shapes.Add(circle);
        foreach (Shape s in shapes)
        { Console.WriteLine($"Color: {s.GetColor()} Area: {s.GetArea():F2}"); }
        
    }
}