class Entry
{
    // attributes
    public string _randomPrompt { get; set; }
    public string _dateAndTime { get; set; }
    public string _entryText { get; set; }

    public void Display()
    {
        Console.Write($"{_dateAndTime} -- {_randomPrompt}\n");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}