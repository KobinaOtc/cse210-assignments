class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment() : base()
    {
        _textBookSection = "Unknown";
        _problems = "Unknown";
    }
    public MathAssignment(string studentName, string topic, string textBooKSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBooKSection;
        _problems = problems;
    }

    public string GetHomeWork()
    {
        return $"{_textBookSection} {_problems}";
    }
}