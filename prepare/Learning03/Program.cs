using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fraction1 = new Fractions();
        Console.WriteLine($"{fraction1.GetTop()}/{fraction1.GetBottom()}");

        Fractions fraction2 = new Fractions();
        Console.WriteLine($"{fraction2.SetTop(5)}/{fraction2.GetBottom()}");

        Fractions fraction3 = new Fractions();
        Console.WriteLine($"{fraction3.GetTop()}/{fraction3.SetBottom(5)}");

        Fractions fraction4 = new Fractions(3, 4);
        Console.WriteLine($"{fraction4.GetFractionString()}");

        Fractions fraction5 = new Fractions(1, 3);
        Console.WriteLine($"{fraction5.GetDecimalValue()}");
    }
}