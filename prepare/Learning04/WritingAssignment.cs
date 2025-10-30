using System;

public class WritingAssignment : Assignment  // subclass, always call the base class with :
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    { return $"{_title} by {_studentName}"; } // _studentName can not be used unless it is "protected" not "private"
}