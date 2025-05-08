using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Score percentage? ");
        string grade = "";
        string scoreText = Console.ReadLine();
        int score = int.Parse(scoreText);
        bool pass = false;

        if (score >= 90)
        {
            grade = "A";
            pass = true;
        }
        else if (score >= 80)
        {
            pass = true;
            if (score >= 87)
            {
                grade = "B+";
            }
            else if (score <= 83)
            {
                grade = "B-";
            }
            else
            {
                grade = "B";
            }
        }
        else if (score >= 70)
        {
            pass = true;
            if (score >= 77)
            {
                grade = "C+";
            }
            else if (score <= 73)
            {
                grade = "C-";
            }
            else
            {
                grade = "C";
            }
        }
        else if (score >= 60)
        {
            pass = false;
            if (score >= 67)
            {
                grade = "D+";
            }
            else if (score <= 63)
            {
                grade = "D-";
            }
            else
            {
                grade = "D";
            }
        }
        else
        {
            grade = "F";
            pass = false;
        }

        if (pass)
        {
            Console.WriteLine($"Your Grade is {grade}, You passed the test");
        }
        else
        {
            Console.WriteLine($"Your Grade is {grade}, You failed the test -- Try Again!");
        }
    }
}