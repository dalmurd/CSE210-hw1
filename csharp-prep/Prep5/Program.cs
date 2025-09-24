using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int age = Birthyear();
        int squaredNumber = SquareNumber(userNumber);

        Console.WriteLine($"Hello, {userName}!");
        Console.WriteLine($"You are {age} years old this year.");
        Console.WriteLine($"Your favorite number is {userNumber}");
        Console.WriteLine($"Your favorite number squared is {squaredNumber}");

    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Prgram!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your Name?");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int Birthyear()
    {
        Console.WriteLine("Enter the Year you were born:");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        return age;
    }

    static int SquareNumber(int userNumber)
    {
        int squaredNumber = userNumber * userNumber;
        return squaredNumber;
    }
}