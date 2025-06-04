using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math1 = new MathAssignment("Kobina Otchere", "Fraction", "Section 3.4", "Problem 1-10");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeWork());
        Console.WriteLine();

        WritingAssignment writing1 = new WritingAssignment("Kobina Otchere", "Literature", "Visions of Humanity");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
        Console.WriteLine();
    }
}