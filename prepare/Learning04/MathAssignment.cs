using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    //invoke the parent with base
    : base(studentName, topic)
    //constructor used to construct the MathAssignment specific variables.
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection}: Problems {_problems}";
    }
}