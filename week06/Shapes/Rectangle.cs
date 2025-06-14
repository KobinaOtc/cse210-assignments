public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle() { }
    public Rectangle(double length, double width, string color)
    {
        _length = length;
        _width = width;
        SetColor(color);
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}