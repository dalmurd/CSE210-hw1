class Checklist : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public Checklist(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Console.WriteLine($"Progress recorded: {_currentCount}/{_targetCount}");

            if (_currentCount == _targetCount)
            {
                _isComplete = true;
                Console.WriteLine($"Checklist goal completed! You earned a bonus of {_bonusPoints} points!");
            }
        }
        else
        {
            Console.WriteLine("This checklist goal is already complete.");
        }
    }

    public override string GetStatus()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} ({_description}) -- Progress: {_currentCount}/{_targetCount}";
    }

public override string Serialize()
{
    return $"Checklist|{_name}|{_description}|{_points}|{_isComplete}|{_currentCount}|{_targetCount}|{_bonusPoints}";
}


}