public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal() {}
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetPoints()
    {
        return _points;
    }

    public void SetName(string name)
    {
        _shortName = name;
    }
    public void SetDescription(string des)
    {
        _description = des;
    }
    public void SetPoints(string points)
    {
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
    
}