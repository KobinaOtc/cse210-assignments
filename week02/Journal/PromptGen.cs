
public class PromptGen
{
    public string PromptUser()
    {
        List<string> prompts =
        [
            "If you had one thing you could do over today, what would it be and why?",
            "What emotion have you felt the most this week, and what triggered it?",
            "What’s one thing you wish more people understood about you?",
            "Describe a moment recently when you felt truly alive. What made it special?",
            "What’s something you’re avoiding, and what’s the real reason behind it?",
            "If your inner child could speak to you today, what would they say?",
            "What does “peace” look and feel like to you right now?",
            "Who or what are you most grateful for today, and why?",
            "What’s one limiting belief you’re ready to let go of?",
            "What would your ideal day look like from morning to night?",
            "What would your ideal day look like from morning to night?",
            "What’s a lesson you’ve learned the hard way, and how has it shaped you?",
            "If fear didn’t exist, what would you do differently?",
            "Write a letter to your future self five years from now. What do you hope they’ve learned or become?",
            "What does success mean to you—personally, not by society’s standards?",
            "What’s a small joy you experienced today that you don’t want to forget?",
        ];
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, 15);
        return prompts[index];
    }
}