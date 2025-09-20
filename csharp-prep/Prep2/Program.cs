using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your grade percentage: ");
        string Gradepercentage = Console.ReadLine();
        int number = int.Parse(Gradepercentage);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is {letter}.");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");

        }
        else
        {
            Console.WriteLine("Study hard, you can do better next time!");
        }
    }
}

