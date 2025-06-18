public class Swimming : Activity
{
    private int _laps;

    public Swimming() : base() { }
    public Swimming(string activity, string date, int activityLength, int laps) : base(activity, date, activityLength)
    {
        _laps = laps;
    }


    // Methods
    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _activityLength) * 60;
    }
    public override double GetPace()
    {
        return _activityLength / GetDistance();
    }
}