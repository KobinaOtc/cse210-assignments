class Activity
{
    // Protected variables
    protected string _startMessage;
    protected string _endMessage;
    protected List<string> _prompts = new List<string>();
    private List<string> _animationLines = new List<string>();

    // Constructors
    public Activity()
    {
        _startMessage = "This activity will help you relax. Clear your mind and focus ";
        _endMessage = "Well done!";
    }
    public Activity(string startMessage)
    {
        _startMessage = startMessage;
    }
    public Activity(string startMessage, string endMessage)
    {
        _startMessage = startMessage;
        _endMessage = endMessage;
    }


    // Methods
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