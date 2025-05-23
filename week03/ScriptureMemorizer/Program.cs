using System;

class Program
{
    static void Main(string[] args)
    {
        int enterCount = 0;
        string quit = "";
        Scripture scripture = new Scripture();
        scripture.SetEdit();
        scripture.Display();
        while (enterCount < 7 && quit != "quit")
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                scripture.Display();
                enterCount++;
            }
            else
            {
                quit = input;
            }
        }
    }
}