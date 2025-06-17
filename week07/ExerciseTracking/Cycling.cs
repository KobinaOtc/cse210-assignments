public class Cycling : Activity
{
    private double _speed;

    public Cycling() : base() { }
    public Cycling(string activity, string date, int activityLength, double speed) : base(activity, date, activityLength)
    {
        _speed = speed;
    }

    // Methods
    public override double GetDistance()
    {
        return (_speed * _activityLength) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}