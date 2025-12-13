using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
{
    new Running(new DateTime(2025, 12, 15), 30, 3.0),
    new Biking(new DateTime(2025, 12, 15), 45, 12.0),
    new Swimming(new DateTime(2025, 12, 15), 40, 20)
};

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}