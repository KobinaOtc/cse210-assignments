public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal() : base() { }
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    { }
    public void SetIsComplete(bool status)
    {
        _isComplete = status;
    }
    public override int RecordEvent()
    {
        _isComplete = IsComplete();
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        return int.Parse(GetPoints());
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetailsString()
    {
        string checkBox = "[ ]";

        if (_isComplete)
        {
            checkBox = "[X]";
        }
        return $"{checkBox} {GetName()} ({GetDescription()})";
    }
    public override string GetStringRepresentation()
    {
        return $"Simple goal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}