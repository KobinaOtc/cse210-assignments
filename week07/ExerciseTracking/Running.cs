public class Running : Activity
{
    private double _distance;

    public Running() : base() { }
    public Running(string activity, string date, int activityLength, double distance) : base(activity, date, activityLength)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _activityLength) * 60;
    }
    public override double GetPace()
    {
        return _activityLength / _distance;
    }
}