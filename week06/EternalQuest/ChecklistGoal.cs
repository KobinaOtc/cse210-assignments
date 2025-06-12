public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    private bool _isComplete = false;


    public ChecklistGoal() : base() { }
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public void SetIsComplete(bool status)
    {
        _isComplete = status;
    }
    public void SetAmountComp(int num)
    {
        _amountCompleted = num;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int points = 0;
        if (!IsComplete())
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
            points = int.Parse(GetPoints());
        }
        else if (IsComplete())
        {
            Console.WriteLine($"Congratulations! You have earned {_bonus} points!");
            points = _bonus;
        }
        return points;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted < _target)
        {
            _isComplete = false;
        }
        else if (_amountCompleted == _target)
        {
            _isComplete = true;
        }
        else if (_amountCompleted > _target)
        {
            _isComplete = true;
        }
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        string checkBox = "[ ]";
        if (_amountCompleted >= _target)
        {
            checkBox = "[X]";
        }
        return $"{checkBox} {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_target}|{_amountCompleted}|{_isComplete}";
    }
}