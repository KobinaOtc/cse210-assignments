public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        IsComplete();
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        return int.Parse(GetPoints());
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        
        return $"Eternal Goal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}