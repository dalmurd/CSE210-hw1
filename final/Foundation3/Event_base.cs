class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private Address _address;

    public Event(string title, string description, DateTime date, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\n" +
               $"Description: {_description}\n" +
               $"Date: {_date:f}\n" +
               $"Address: {_address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{GetType().Name}: {_title} on {_date:d}";
    }
}
