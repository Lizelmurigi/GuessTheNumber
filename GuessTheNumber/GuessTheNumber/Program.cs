using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            int divisible = randomizer.Next(1, 75);
            int oddNumber = randomizer.Next(1, 75);
            int guess = 0;

            while (guess != divisible)
            {
                // Let the player enter a number
                Console.WriteLine("What is your guess?");
                string guessText = Console.ReadLine();
                // Evaluate the player's guess and respond
                guess = int.Parse(guessText);
                if (guess == divisible)
                {
                    Console.WriteLine("You Win! 75 points");

                }


                else if (guess == oddNumber)

                { Console.WriteLine("Lose! 0 Points"); }
            }

            
        }
    }
}
