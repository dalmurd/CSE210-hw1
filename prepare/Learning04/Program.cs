using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your homework assignments!");
        Console.WriteLine("Enter your name: ");
        string studentName = Console.ReadLine();

        Console.WriteLine("\nChoose the type of assignment to work on: ");
        Console.WriteLine("1. Math Assignment");
        Console.WriteLine("2. Writing Assignment");
        Console.Write("Enter your choice here: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Assignment Summary:");
            Console.WriteLine($"Topic: Fractions");
            Console.WriteLine("Textbook Sections: 7.3");
            Console.WriteLine("Practice Problems: 8-19");

        }
        else if (choice == "2")
        {
            Console.WriteLine("Assignment Summary");
            Console.WriteLine("Topic: World History");
            Console.WriteLine("Title of Paper: Causes of World War II");

        }
        else
        {
            Console.WriteLine("Enter a valid input");
        }
    }
}