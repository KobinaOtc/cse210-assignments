using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool active = true;
        int sum = 0;
        int largest = 0;
        float average = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (active)
        {
            Console.Write("Enter number: ");
            string numTxt = Console.ReadLine();
            int num = int.Parse(numTxt);

            if (num == 0)
            {
                foreach (int i in numbers)
                {
                    sum += i;
                    if (i > largest)
                    {
                        largest = i;
                    }
                }
                average = sum / numbers.Count;

                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The average is: {average}");
                Console.WriteLine($"The largest is: {largest}");

                active = false;
            }
            else
            {
                numbers.Add(num);
            }

        }
    }
}