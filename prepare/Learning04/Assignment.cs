using System;

//This is my base, or parent, class. 
//It will be inherited by the more specialized classes so its functionality can be used by those classes.
public class Assignment
{
    private string _studentName;
    private string _topic;

    //this is an example of a constructor. It receives name and topic from user wherever it is called.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //In case an inherited or other function wants the values of topic and studentname, here are getters.
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}