public abstract class Activity
{
    protected string _date;
    protected int _activityLength;
    private string _activity;

    public Activity() { }
    public Activity(string activity, string date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
        _activity = activity;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $"{_date} {_activity} ({_activityLength} mins) - Distance {GetDistance()} km, Speed {GetSpeed()} kmph, Pace: {GetPace()} min per km";
    }
}