using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int numberOfGuesses = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            numberOfGuesses = numberOfGuesses + 1;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"Congratulations! The Magic Number was {magicNumber}. You guessed it in {numberOfGuesses} tries.");
            }

        }

        Console.WriteLine("Thanks for playing!");

    }
}