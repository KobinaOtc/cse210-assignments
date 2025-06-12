using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square squ = new Square(3, "blue");
        Rectangle rec = new Rectangle(4, 7, "orange");
        Circle cir = new Circle(5, "red");
        shapes.Add(squ);
        shapes.Add(rec);
        shapes.Add(cir);

        foreach (Shape shape in shapes)
        {
            DisplayDetails(shape);
        }
    }

    public static void DisplayDetails(Shape shape)
    {
        Console.WriteLine($"Shape Area -> {shape.GetArea()}, Color -> {shape.GetColor()}");
    }
}