using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Today;
        string date = dateTime.ToString("dd MMM yyyy");
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running("Running", date, 30, 4));
        activities.Add(new Running("Running", date, 40, 7));
        activities.Add(new Running("Running", date, 60, 12));
        activities.Add(new Cycling("Cycling", date, 29, 15));
        activities.Add(new Cycling("Cycling", date, 26, 20));
        activities.Add(new Cycling("Cycling", date, 45, 11));
        activities.Add(new Swimming("Swimming", date, 50, 8));
        activities.Add(new Swimming("Swimming", date, 55, 23));
        activities.Add(new Swimming("Swimming", date, 73, 24));

        // Iterate through them
        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}