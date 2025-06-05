using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity reflectionActivity = new ReflectionActivity("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity listingActivity = new ListingActivity("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        bool active = true;
        while (active)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start Breathing Activity");
            Console.WriteLine("     2. Start Reflection Activity");
            Console.WriteLine("     3. Start Listing Activity");
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                breathingActivity.Activate();
            }
            else if (option == "2")
            {
                reflectionActivity.SetStart();
            }
            else if (option == "3")
            {
                listingActivity.SetStart();
            }
            else if (option == "4")
            {
                active = false;
            }
            else
            {
                Console.Write("Wrong input! Accepted input include: '1', '2', '3' or '4' ");
                Thread.Sleep(6000);
            }
        }
    }
}