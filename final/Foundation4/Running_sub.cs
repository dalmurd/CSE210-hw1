class Running : Activity
{
    private double _distanceMiles;

    public Running(DateTime date, int minutes, double distanceMiles)
        : base(date, minutes)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance() => _distanceMiles;

    public override double GetSpeed() =>
        (_distanceMiles / GetMinutes()) * 60;

    public override double GetPace() =>
        GetMinutes() / _distanceMiles;
}
