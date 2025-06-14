class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment() : base()
    {
        _title = "None";
    }
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} - {_title}";
    }
}