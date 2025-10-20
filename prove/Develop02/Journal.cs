class Journal
{
    // attribute
    public List<Entry> _entryList = new List<Entry>();

    // behaviors
    public void AddEntry(Entry entry)
    {
        _entryList.Add(entry);
    }
    public void Display()
    {
        if (_entryList.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        Console.WriteLine("-----------------");
        foreach (Entry entry in _entryList)
        {
            Console.WriteLine($"{entry._dateAndTime}");
            Console.WriteLine($"Prompt: {entry._randomPrompt}");
            Console.WriteLine($"Response: {entry._entryText}");
            Console.WriteLine("-----------------");
            entry.Display();

        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entryList)
            {
                outputFile.WriteLine($"{entry._dateAndTime}|{entry._randomPrompt}|{entry._entryText}");
            }
        }
        Console.WriteLine($"Entries saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found!");
            return;
        }

        _entryList.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._dateAndTime = parts[0];
                entry._randomPrompt = parts[1];
                entry._entryText = parts[2];
                _entryList.Add(entry);
            }
        }
        Console.WriteLine($"Entries Loaded from {filename}");

    }
}