using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        int number;
        List<int> numbers = new List<int>();

        do
        {
            Console.WriteLine("Enter a number (or 0 to stop):");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);

        } while (number != 0);


        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
           
            

    }
}