using System;

class Menu
{
    public void Display()
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            // Read and convert input
            string input = Console.ReadLine();
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ReadKey();
                continue;
            }

            // Perform the chosen action
            if (choice == 1)
                new Breathing().Run();
            else if (choice == 2)
                new Reflection().Run();
            else if (choice == 3)
                new Listing().Run();
            else if (choice == 4)
                Console.WriteLine("Goodbye!");
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
                Console.ReadKey();
            }
        }
    }
}
