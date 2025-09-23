using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the magic number:");
        int magicNumber = int.Parse(Console.ReadLine());
         Console.WriteLine("What is your guess?");
        int guess = int.Parse(Console.ReadLine());
    while (guess != magicNumber)
        if (guess == magicNumber)
        {
            Console.WriteLine("You guessed the magic number!");

        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Too Low! Guess a higher number.");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Too High! Guess a lower number.");
        }
        else
        {
            Console.WriteLine("You did not enter a valid number.");
        }
    }
}