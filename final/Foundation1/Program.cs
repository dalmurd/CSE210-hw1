using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The Matrix", "The Wachowskis");
        Comments comments1 = new Comments("", "");

        comments1.AddComment("KingMorbis: Amazing movie, I would choose the red pill!");
        comments1.AddComment("ScienceBob: A classic sci-fi film.");
        comments1.AddComment("JOnWick4Life: Loved the action scenes.");

        Console.WriteLine($"Video Title: {video1.GetTitle()}");
        Console.WriteLine($"Producer: {video1.GetProducer()}");
        Console.WriteLine("Comments:");
        Console.WriteLine("_______________________________");
        foreach (string comment in comments1.GetComments())
        {Console.WriteLine($"- {comment}");}

        Console.WriteLine();

        Video video2 = new Video("Calculus 2 Lecture 7.1: Integration by Parts", "Professor Leonard");
        Comments comments2 = new Comments("", "");

        comments2.AddComment("rubenprince100: i dont even do calculus but just spent 9 hours watching this series");
        comments2.AddComment("Dee Randhawa: Prof. Leonard: 'Show of hands if you are ok with that one' Me: Actually raising my hand with a smile on my face :D'");
        comments2.AddComment("geragal2008: 'Superman is now a teacher, and not any teacher a math teacher. How cool is that, no wonder he can fly.'");

        Console.WriteLine($"Video Title: {video2.GetTitle()}");
        Console.WriteLine($"Producer: {video2.GetProducer()}");
        Console.WriteLine("Comments:");
        Console.WriteLine("_______________________________");
        foreach (string comment in comments2.GetComments())
        {Console.WriteLine($"- {comment}");}

        Console.WriteLine();
        
        Video video3 = new Video("Jeremy, Richard & James Redesign Mobility Scooters | Top Gear Classic", "BBC Studios");
        Comments comments3 = new Comments("", "");
        comments3.AddComment("WolvieX24: 'Because we were working as a team, we decided to JUST leave him'");
        comments3.AddComment("Dalers84UK: 'My leg has fallen off' 😂 something you wouldn't normally hear during any situation");
        comments3.AddComment("godlovejimmy: 'May is like a student who wrote his own questions in exam and still got them wrong 😂😂😂'");

        Console.WriteLine($"Video Title: {video3.GetTitle()}");
        Console.WriteLine($"Producer: {video3.GetProducer()}");
        Console.WriteLine("Comments:");
        Console.WriteLine("_______________________________");
        foreach (string comment in comments3.GetComments())
        {Console.WriteLine($"- {comment}");}

    }
}