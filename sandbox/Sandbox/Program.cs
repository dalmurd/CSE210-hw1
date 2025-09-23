using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

// 'This is how you capitalize a string in C#'
        string randomWord = "hello sandbox world!";
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string capitalized = textInfo.ToTitleCase(randomWord);
        Console.WriteLine(capitalized);
    }
}