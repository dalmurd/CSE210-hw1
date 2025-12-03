class Video
{
    public string _title;
    public string _producer;

    public Video(string title, string producer)
    {
        _title = title;
        _producer = producer; 
    }

    public string GetTitle()
    { return _title;}

    public string GetProducer()
    { return _producer; }

}