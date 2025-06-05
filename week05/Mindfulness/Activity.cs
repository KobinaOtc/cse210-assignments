class Activity
{
    // Protected variables
    protected string _startMessage;
    protected string _endMessage;
    protected List<string> _prompts = new List<string>();
    private List<string> _animationLines = new List<string>();
    Random randomGen = new Random();


    // Constructors
    public Activity()
    {
        _startMessage = "This activity will help you relax. Clear your mind and focus ";
        _endMessage = "Well done!";
    }
    public Activity(string startMessage)
    {
        _startMessage = startMessage;
        _endMessage = "Well done!";
    }
    public Activity(string startMessage, string endMessage)
    {
        _startMessage = startMessage;
        _endMessage = endMessage;
    }


    // Methods
    public int GetSeconds(string activity)
    {
        Console.WriteLine($"Welcome to the {activity} Activity");
        Console.WriteLine();
        Console.WriteLine(_startMessage);
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string secStr = Console.ReadLine();
        int secs = int.Parse(secStr);
        return secs;
    }
    public void GetReady()
    {
        Console.WriteLine("Get Ready...");
        LoadingAnimation(3);
        Console.WriteLine();
    }

    private int IndexGen(List<int> indexes)
    {
        int index = randomGen.Next(0, _prompts.Count - 1);
        int counter = 0;
        while (indexes.Contains(index) && counter < 100)
        {
            index = randomGen.Next(0, _prompts.Count - 1);
            counter++;
        }
        return index;
    }
    protected void GetRandomPrompt(int secs, List<int> indexes, string activity)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(secs);
        if (activity == "reflection")
        {
            while (DateTime.Now < endTime)
            {
                int i = IndexGen(indexes);
                Console.WriteLine();
                Console.Write("> ");
                Console.Write(_prompts[i]);
                Console.Write(" ");
                LoadingAnimation(8);
                Console.WriteLine();
                indexes.Add(i);
            }
        }
        else if (activity == "listing")
        {
            int i = IndexGen(indexes);
            Console.WriteLine($"------{_prompts[i]}------");
            indexes.Add(i);
        }
    }
    public void LoadingAnimation(int secs)
    {
        _animationLines.Add("|");
        _animationLines.Add("/");
        _animationLines.Add("-");
        _animationLines.Add("\\");
        _animationLines.Add("|");
        _animationLines.Add("/");
        _animationLines.Add("-");
        _animationLines.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(secs);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(_animationLines[i]);
            Thread.Sleep(80);
            Console.Write("\b \b");
            i++;
            if (i >= _animationLines.Count)
            {
                i = 0;
            }
        }
    }
    public void CountDownTimer(int secs)
    {
        while (secs >= 0)
        {
            Console.Write(secs);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            secs--;
        }
    }
    
}