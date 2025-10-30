using System;

public class MathAssignment : Assignment
{
    private string _textbookSection; //specific field for Mathassignment class
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;

    }

    public string GetHomeworkList()
    { return $"Section {_textbookSection} Problems {_problems}"; }


}
