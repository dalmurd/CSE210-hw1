using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        
        int magicNumber = RandomNumberGenerator.GetInt32(1, 101);
        int number = 0;

        while (number != 1)
        {
            Console.WriteLine("What is your guess?");
            int user = int.Parse(Console.ReadLine());
            if (user == magicNumber)
            {
                Console.WriteLine("You guessed the magic number!");
                number = 1;
            }
            else if (user < magicNumber)
                Console.WriteLine("Too Low! Guess a higher number.");
            else if (user > magicNumber)
                Console.WriteLine("Too High! Guess a lower number.");
            else
                Console.WriteLine("You did not enter a valid number.");
        }
    }
}