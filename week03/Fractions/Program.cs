using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions one = new Fractions();
        Fractions five = new Fractions(5);
        Fractions fractionOne = new Fractions(3, 4);
        Fractions fractionTwo = new Fractions(1, 3);


        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
        Console.WriteLine(five.GetFractionString());
        Console.WriteLine(five.GetDecimalValue());
        Console.WriteLine(fractionOne.GetFractionString());
        Console.WriteLine(fractionOne.GetDecimalValue());
        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionTwo.GetDecimalValue());
    }
}