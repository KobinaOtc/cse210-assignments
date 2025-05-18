using System;

class Program
{
    static void Main(string[] args)
    {
        bool active = true;
        Entries entries = new Entries();
        List<string> prompts = new List<string>();
        prompts.Add("If you had one thing you could do over today, what would it be and why?");
        prompts.Add("What emotion have you felt the most this week, and what triggered it?");
        prompts.Add("What’s one thing you wish more people understood about you?");
        prompts.Add("Describe a moment recently when you felt truly alive. What made it special?");
        prompts.Add("What’s something you’re avoiding, and what’s the real reason behind it?");
        prompts.Add("If your inner child could speak to you today, what would they say?");
        prompts.Add("What does “peace” look and feel like to you right now?");
        prompts.Add("Who or what are you most grateful for today, and why?");
        prompts.Add("What’s one limiting belief you’re ready to let go of?");
        prompts.Add("What would your ideal day look like from morning to night?");
        prompts.Add("What would your ideal day look like from morning to night?");
        prompts.Add("What’s a lesson you’ve learned the hard way, and how has it shaped you?");
        prompts.Add("If fear didn’t exist, what would you do differently?");
        prompts.Add("Write a letter to your future self five years from now. What do you hope they’ve learned or become?");
        prompts.Add("What does success mean to you—personally, not by society’s standards?");
        prompts.Add("What’s a small joy you experienced today that you don’t want to forget?");
        Random randomGenerator = new Random();

        while (active)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string ans = Console.ReadLine();
            DateTime currentDateTime = DateTime.Now;
            string dataString = currentDateTime.ToShortDateString();
            int index = randomGenerator.Next(0, 14);

            if (ans == "1")
            {
                Entry entry = new Entry();
                entry._date = dataString;
                entry._prompt = prompts[index];
                Console.WriteLine(entry._prompt);
                entry._response = Console.ReadLine();
                entries._entries.Add(entry);
            }
            else if (ans == "2")
            {
                entries.Display();
            }
            else if (ans == "3")
            {
                Console.WriteLine("What is the file name?");
                Console.Write("> ");
                entries._fileName = Console.ReadLine();
                entries.Load();
            }
            else if (ans == "4")
            {
                Console.WriteLine("What is the file name? ");
                Console.Write("> ");
                entries._fileName = Console.ReadLine();
                entries.Save();
            }
            else if (ans == "5")
            {
                Console.WriteLine("Quiting ...");
                Console.WriteLine("DONE.");
                active = false;
            }
            else
            {
                Console.WriteLine("Wrong input try again.");
            }
        }

    }
}