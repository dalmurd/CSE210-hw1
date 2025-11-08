class Reflection : Activity
{
    private List<string> _prompts = new()
    {
       "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection()
        : base("Reflection", "This activity will help you refelct on times in yoru life when you have shown strength and resilience. ")
    { }
        
    public void Run()
    {
        DisplayMain();
        int duration = GetDuration();

        Random rand = new();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("Consider the following questions: ");
        Timer.DoctorStrange(3);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            Timer.DoctorStrange(4);
        }
        DisplayEndingMessage();
    }
}