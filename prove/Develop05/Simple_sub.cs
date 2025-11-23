class Simple : Goal
{
    public Simple(string name, string description, int points)
        : base(name, description, points)
        {}
    
    public void Display()
    {
        string status = " ";
        if (_isComplete)
        { status = "X";}
        else
        {status = " ";}

        Console.WriteLine($"[{status}] {_name}: ({_description})");
    }

    public override string Serialize()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_isComplete}";
    }

}