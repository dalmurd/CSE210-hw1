class Activity
{
    // Behaviors
    private string _activityName;
    private string _activitiyDescriptition;
    private int _duration;

    public Activity(string AName, string ActDesc) // Constructor to define terms
    {
        _activityName = AName;
        _activitiyDescriptition = ActDesc;
    }

    //Methods
    public void DisplayMain()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity!");
        Console.WriteLine();
        Console.WriteLine(_activitiyDescriptition);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like this session to last?");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready to begin... ");
        Timer.DoctorStrange(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Good job! You've completed the activity!");
        Timer.DoctorStrange(3);
        Console.WriteLine($"You have completed {_activityName} activity for {_duration} seconds!");
        Timer.DoctorStrange(3);
    }

    //Timer()
    public int GetDuration()
    { return _duration; }

    //GetName()
    public string GetName()
    { return _activityName; }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
        
    
    // Loading animation()
    
}