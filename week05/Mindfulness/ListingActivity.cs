class ListingActivity : Activity
{
    private List<int> _usedIndex = new List<int>();
    private List<string> _reflections = new List<string>();
    public ListingActivity() : base() { }
    public ListingActivity(string startMessage) : base(startMessage) { }

    private void SetPrompts()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void SetStart()
    {
        SetPrompts();
        int secs = GetSeconds("Listing");
        Console.WriteLine("List as many responses for the following prompt:");
        GetRandomPrompt(secs, _usedIndex, "listing");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        CountDownTimer(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(secs);
        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string intput = Console.ReadLine();
            _reflections.Add(intput);
        }
        Console.WriteLine();
        Console.WriteLine($"You have listed {_reflections.Count} items!");
        Console.WriteLine();
        Console.WriteLine(_endMessage);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {secs} seconds of the Listing Activity");
        LoadingAnimation(5);
        Console.Clear();
    }
}