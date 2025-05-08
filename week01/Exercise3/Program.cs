using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);
        int guessNum = 0;
        int guess = 0;
        // Stretch Challenge
        bool play = true;
        // Old Code -----------------------------------
        // Console.Write("What is the magic number? ");
        // string magicTxt = Console.ReadLine();
        // magicNum = int.Parse(magicTxt);
        // --------------------------------------------

        while (play)
        {
            Console.Write("What is your guess? ");
            string guessTxt = Console.ReadLine();
            guess++;

            guessNum = int.Parse(guessTxt);

            if (magicNum == guessNum)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"Guess Count: {guess}");
                Console.Write("Do you want to play again? ");
                string ans = Console.ReadLine();

                if (ans != "yes")
                {
                    play = false;
                    Console.WriteLine("Come Back Soon!");
                }
                else
                {
                    magicNum = randomGenerator.Next(1, 100);
                    guess = 0;
                }
            }
            else if (magicNum > guessNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }
    }
}