using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Joshua", 3, 5);
        string verseText = "And Joshua said to the people, 'Sanctify yourselves; for tomorrow the Lord will do wonders among you.'";
        List<Word> words = new List<Word>();
        foreach (string word in verseText.Split(' '))
        { words.Add(new Word(word)); }

        Scripture scripture = new Scripture(reference, words);
        while (true)
        {
            Console.Clear(); // allows scripture to disappear on the same line in terminal, without rewriting it multiple tiimes.
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to end program.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            { break; }

            scripture.HideRandomWords(3); // Hides 3 random words at a time on Enter
            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                scripture.Display();
                break;
            }
        }

    }
}