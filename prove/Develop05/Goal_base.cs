class Goal
{
    protected bool _isComplete;
    protected string _name;
    protected string _description;
    protected int _points;
    public string Name => _name;


    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;

    }

    public virtual void RecordEvent()
    {
        _isComplete = true;
    }

    public virtual string GetStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }

public virtual string Serialize()
{
    return $"Simple|{_name}|{_description}|{_points}|{_isComplete}";
}

public static Goal CreateGoal()
{
    Console.WriteLine("Select goal type:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");

    if (!int.TryParse(Console.ReadLine(), out int type))
    {
        Console.WriteLine("Invalid input.");
        return null;
    }

    Console.Write("Enter goal name: ");
    string name = Console.ReadLine();

    Console.Write("Enter goal description: ");
    string description = Console.ReadLine();

    Console.Write("Enter goal points: ");
    if (!int.TryParse(Console.ReadLine(), out int points))
    {
        Console.WriteLine("Invalid points input.");
        return null;
    }

    switch (type)
    {
        case 1:
            return new Simple(name, description, points);

        case 2:
            return new Eternal(name, description, points);

        case 3:
            Console.Write("How many times to complete it? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            return new Checklist(name, description, points, target, bonus);

        default:
            Console.WriteLine("Invalid goal type.");
            return null;
    }
}

    public static void ListGoals(List<Goal> goals)
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetStatus()}");
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public static void SaveGoals(List<Goal> goals)
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }

        Console.WriteLine("Goals saved successfully. Press any key to continue...");
        Console.ReadKey();
    }

public static List<Goal> LoadGoals()
{
    Console.Write("Enter filename to load goals: ");
    string filename = Console.ReadLine();
    List<Goal> goals = new List<Goal>();

    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found. Press any key to continue...");
        Console.ReadKey();
        return goals;
    }

    using (StreamReader reader = new StreamReader(filename))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split('|');
            string type = parts[0];

            if (type == "Simple")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);

                Simple goal = new Simple(name, desc, points);
                goal._isComplete = complete;
                goals.Add(goal);
            }
            else if (type == "Eternal")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);

                goals.Add(new Eternal(name, desc, points));
            }
            else if (type == "Checklist")
            {
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);
                int current = int.Parse(parts[5]);
                int target = int.Parse(parts[6]);
                int bonus = int.Parse(parts[7]);

                Checklist cl = new Checklist(name, desc, points, target, bonus);
                cl._isComplete = complete;
                cl.GetType()
                  .GetField("_currentCount", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                  .SetValue(cl, current);

                goals.Add(cl);
            }
        }
    }

    Console.WriteLine("Goals loaded successfully. Press any key...");
    Console.ReadKey();
    return goals;
}
}