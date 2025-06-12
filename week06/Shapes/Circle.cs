public class Circle : Shape
{
    private double _radius;
    public Circle() { }
    public Circle(double radius, string color)
    {
        _radius = radius;
        SetColor(color);
    }

    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
    
}