class Breathing : Activity
{
    public Breathing()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.")
    { }


    public void Run()
    {
        DisplayMain();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in... ");
            Countdown(3);
            Console.WriteLine();
            Console.WriteLine("Breath out... ");
            Countdown(3);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}