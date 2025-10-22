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

            int visible = scripture.VisibleWordCount();
            if (visible > 3)
            {
                scripture.HideRandomWords(3); // Hides 3 random words at a time on Enter
            }
            else
            {
                scripture.HideRandomWords(visible); // runs to hide the remaining words if less then 3 are left
                Console.Clear();
                scripture.Display();
                break;
            }

            if (scripture.AllWordsHidden())
            {
                Console.Clear(); // displays the final scripture with all words hidden before exiting
                scripture.Display();
                break;
            }
        }

    }
}