class BreathingActivity : Activity
{
    public BreathingActivity(string startMessage) : base(startMessage) { }

    public void Activate()
    {
        int secs = GetSeconds("Breathing");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(secs);
        GetReady();
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            CountDownTimer(3);
            Console.WriteLine();
            Console.Write("Breathe out...");
            CountDownTimer(5);
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine(_endMessage);
        Console.WriteLine($"You have completed another {secs} seconds of the Breathing Activity");
        LoadingAnimation(7);
        Console.Clear();
    }
}