using System;
using System.Collections.Generic;

class Menu
{
    private int _scoreTracker;

    private int _totalScore;

    public List<Goal> goals;

    public Menu()
    {
        _scoreTracker = 0;
        _totalScore = 0;
        goals = new List<Goal>();
    }

    public void DisplayMenu()
    {
        int choice = 0;
        while (choice != 6)
        { 
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals"); // displays the list of goals 
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals"); // loads goals into a list file
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ReadKey();
                continue;
            }

            if (choice ==1)
            {
                Goal newGoal = Goal.CreateGoal();
                if (newGoal != null)
                {
                    goals.Add(newGoal);
                    Console.WriteLine("Goal created successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to create goal.");
                }
            }
            else if (choice == 2)
            {
                Goal.ListGoals(goals);
            }
            else if (choice == 3)
            {
                Goal.SaveGoals(goals);
            }
            else if (choice == 4)
            {
                goals = Goal.LoadGoals();
            }
            else if (choice == 5)
            {
                if (goals.Count == 0)
                {
                    Console.WriteLine("No goals to record an event for.");
                }
                else
                {
                    Console.WriteLine("Which goal did you accomplish?");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].Name}");
                    }

                    Console.Write("Enter goal number: ");
                    if (int.TryParse(Console.ReadLine(), out int goalChoice) &&
                        goalChoice > 0 && goalChoice <= goals.Count)
                    {
                        goals[goalChoice - 1].RecordEvent();
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                    }
                }
                Console.ReadKey();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Quiting Goal Tracker. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
                Console.ReadKey();
            }

        }
    }
}