class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, Address address,
                   string speaker, int capacity)
        : base(title, description, date, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() +
               $"\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
