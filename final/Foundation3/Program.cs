using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "83440");

        Event lecture = new Lecture(
            "Tech Talk",
            "AI: How to Integrate a New Friend into Your Life",
            DateTime.Now,
            address1,
            "Dr. Smith",
            100);

        Event reception = new Reception(
            "Company Mixer",
            "Networking event",
            DateTime.Now.AddDays(1),
            address1,
            "rsvp@event.com");

        Event outdoor = new OutdoorGathering(
            "Summer Festival",
            "Music and food",
            DateTime.Now.AddDays(2),
            address1,
            "Sunny, 75°F");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("\n--------------------\n");
        }

    }
}