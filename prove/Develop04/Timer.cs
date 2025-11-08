using System;
class Timer
{
    private static DateTime _timer;

    public static void SetTimer(int duration)
    {
        DateTime start = DateTime.Now;
        _timer = start.AddSeconds(duration);

    }

    public static bool TisExpired()
    {
        if (DateTime.Now > _timer)
        { return true; }
        else
        { return false; }
    }

    public static void DoctorStrange(int duration) // pause with animation constructor 
    {
        List<string> animationString;
        animationString = ["|", "\\", "-", "/"];
        int counter = 0;
        SetTimer(duration);
        while (!TisExpired())
        {
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write($"{animationString[counter % 4]}");
            counter += 1;
        }
    }

}