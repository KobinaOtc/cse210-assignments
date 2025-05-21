public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetTop(int num)
    {
        _top = num;
    }
    public void SetBottom(int num)
    {
        _bottom = num;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double top = Convert.ToDouble(_top);
        double bottom = Convert.ToDouble(_bottom);
        double decimalValue = top / bottom;
        return decimalValue;
    }
}