class ReflectionActivity : Activity
{
    public ReflectionActivity() : base() { }
    public ReflectionActivity(string startMessage) : base(startMessage) { }

    private void SetPrompts()
    {
        _prompts.Add("Why was this experience meaningful to you?");
        _prompts.Add("Have you ever done anything like this before?");
        _prompts.Add("How did you get started?");
        _prompts.Add("How did you feel when it was complete?");
        _prompts.Add("What made this time different than other times when you were not as successful?");
        _prompts.Add("What is your favorite thing about this experience?");
        _prompts.Add("What could you learn from this experience that applies to other situations?");
        _prompts.Add("What did you learn about yourself through this experience?");
        _prompts.Add("How can you keep this experience in mind in the future?");
    }
    public void SetStart()
    {
        SetPrompts();
        int secs = GetSeconds("Reflection");
        Console.Clear();
        GetReady();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine("----Think of a time when you did something really difficult----");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("When you have something in mind press <enter>");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.WriteLine();
            Console.Write("You may begin in ...");
            CountDownTimer(5);
            GetRandomPrompt(secs, _usedIndex, "reflection");
            Console.WriteLine(_endMessage);
        }
        Console.WriteLine();
        Console.WriteLine($"You have completed another {secs} seconds of the Reflrction Activity");
        LoadingAnimation(5);
        Console.Clear();
    }
}