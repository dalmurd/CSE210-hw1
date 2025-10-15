using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Prompts myPrompt = new Prompts();
        Journal myJournal = new Journal();
        Console.WriteLine("Welcome to your Journal! Type 'menu' to see your options.");

        Entry myEntry = new Entry();

        Entry anotherEntry = new Entry();

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "menu")
            {
                Console.WriteLine("1. Type 'prompt' to get a random journal prompt.");
                Console.WriteLine("2. Type 'display' to see all entries.");
                Console.WriteLine("3. Type 'save' to save your entries to a file.");
                Console.WriteLine("4. Type 'load' to load entries from the file.");
                Console.WriteLine("5. Type 'quit' to exit the program.");
            }
            else if (input.ToLower() == "prompt")
            {
                // Use the existing myJournal instance

                //get a random prompt
                string prompt = myPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);

                // get the users response: 
                Console.WriteLine("Please write your response below:");
                string response = Console.ReadLine();

                // Create a new entry and store the prompt and response
                Entry newEntry = new Entry();
                newEntry._randomPrompt = prompt;
                newEntry._entryText = response;
                newEntry._dateAndTime = DateTime.Now.ToString("mm/dd/yyyy");

                //Save the entry to the journal
                myJournal._addEntry(myEntry);
                Console.WriteLine("Entry Recorded!");


            }

            else if (input.ToLower() == "display")
            {
                myJournal._Display();
            }

            else if (input.ToLower() == "save")
            {
                Console.WriteLine("Enter a file name for the txt file: (e.g. myJournal.txt): ");
                string filename = Console.ReadLine();
                myJournal._SaveToFile(filename);
            }

            else if (input.ToLower() == "Load")
            {
                Console.WriteLine("Enter the file name to load");
                string filename = Console.ReadLine();
                myJournal._LoadFromFile(filename);
            }

            else if (input.ToLower() == "quit")
            {
                break;
            }

            else
            {
                Console.WriteLine("Please type 'quit' to exit.");
            }
        }






    }
}