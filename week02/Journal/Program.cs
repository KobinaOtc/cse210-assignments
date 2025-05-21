using System;

class Program
{
    static void Main(string[] args)
    {
        bool active = true;
        Entries entries = new Entries();
        PromptGen prompt = new PromptGen();

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
            // int index = randomGenerator.Next(0, 14);

            if (ans == "1")
            {
                Entry entry = new Entry();
                entry._date = dataString;
                entry._prompt = prompt.PromptUser();
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