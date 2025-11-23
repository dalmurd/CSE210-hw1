class Eternal : Goal
{
    public Eternal(string name, string description, int points)
        : base(name, description, points)
        {}

    public override void RecordEvent()
    {
        Console.WriteLine("Eternal goals cannot be completed. Event recorded, but goal remains incomplete.");
    }

    public override string GetStatus()
    {
        return $"[ ] {_name} ({_description}) -- Eternal Goal";
    }

public override string Serialize()
{
    return $"Eternal|{_name}|{_description}|{_points}";
}



}