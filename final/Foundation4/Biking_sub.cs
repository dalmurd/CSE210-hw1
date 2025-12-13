class Biking : Activity
{
    private double _speedMph;

    public Biking(DateTime date, int minutes, double speedMph)
        : base(date, minutes)
    {
        _speedMph = speedMph;
    }

    public override double GetSpeed() => _speedMph;

    public override double GetDistance() =>
        (_speedMph * GetMinutes()) / 60;

    public override double GetPace() =>
        60 / _speedMph;
}
