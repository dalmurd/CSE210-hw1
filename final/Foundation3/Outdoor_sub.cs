class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, Address address,
                            string weatherForecast)
        : base(title, description, date, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() +
               $"\nType: Outdoor Gathering\nWeather: {_weatherForecast}";
    }
}
