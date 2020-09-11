using System;


namespace Deliverable_2_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string headsOrTailsGuess;
            int numberOfFlips;
            Random ranNum = new Random();
            int correctCount = 0;

            Console.WriteLine("Coin Game!\n");
            Console.WriteLine("Guess which will have more: heads or tails?");
            headsOrTailsGuess = Console.ReadLine();

            string headsOrTailsGuess2 = headsOrTailsGuess.ToUpper();
            Console.WriteLine("How many times shall we flip a coin?");
            numberOfFlips = int.Parse(Console.ReadLine());

            if (headsOrTailsGuess2.Contains("HEADS"))
            {
                for (int i = 0; i < numberOfFlips; i++)
                {
                    int coinFlip = ranNum.Next(0, 99);
                    if (coinFlip < 50)
                    {
                        Console.WriteLine("Heads");
                        correctCount++;
                    }
                    else
                    {
                        Console.WriteLine("Tails");
                    }

                }

            }
            else if (headsOrTailsGuess2.Contains("TAILS"))
            {
                for (int i = 0; i < numberOfFlips; i++)
                {
                    int coinFlip = ranNum.Next(0, 99);
                    if (coinFlip > 50)
                    {
                        Console.WriteLine("Heads");

                    }
                    else
                    {
                        Console.WriteLine("Tails");
                        correctCount++;
                    }

                }
            }
            else 
            {
                Console.WriteLine("Error. Must use Heads or Tails only.");
            }
            decimal guessPercent = (decimal)correctCount / numberOfFlips;
            Console.WriteLine($"Your guess, {headsOrTailsGuess}, came up {correctCount} time(s). That's {guessPercent:P2}.");

        }
    }
}
