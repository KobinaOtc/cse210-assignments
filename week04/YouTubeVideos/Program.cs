using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to wash a car?", "Kevin Sharp", 32000);
        Video video2 = new Video("Chelsea news", "Younes Talks Football", 5450);
        Video video3 = new Video("CHELSEA TO BEAT LIVERPOOL FOR HATO?", "Younes Talks Football", 7650);

        Channel kevinSharp = new Channel(video1._author);
        Channel younes = new Channel(video2._author);

        Comment comment1 = new Comment("Alice", "Great explanation!");
        Comment comment2 = new Comment("Bob", "Very helpful, thank you!");
        Comment comment3 = new Comment("Charlie", "I learned a lot from this video.");
        Comment comment4 = new Comment("David", "Challenging but rewarding content.");
        Comment comment5 = new Comment("Eve", "Needs more examples, but good overview.");
        Comment comment6 = new Comment("GullyFoot", "Was good to see Emma Hayes joining in the celebrations last night… once a blue, always a blue");
        Comment comment7 = new Comment("Michael", "We've won it allll, we've won it alllll. Champions of Europe we won it alllll");
        Comment comment8 = new Comment("Bokiyuto", "One of the most positive chelsea fan channel... Love you Yan");
        Comment comment9 = new Comment("Izzy", "Estevao, Paez, Santos…Exciting times!");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        // -------- Display video details ---------
        Console.WriteLine("Displaying Video Details");
        video1.DisplayVideoDetails();
        Console.WriteLine($"Number of comments for {video1._title} are {video1.GetNumberOfComments()}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        video2.DisplayVideoDetails();
        Console.WriteLine($"Number of comments for {video2._title} are {video2.GetNumberOfComments()}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        video3.DisplayVideoDetails();
        Console.WriteLine($"Number of comments for {video3._title} are {video3.GetNumberOfComments()}");

        Console.WriteLine();
    }
}