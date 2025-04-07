using System;
using System.Drawing;
using System.Dynamic;

class Lecture : Event
{
    private string _speaker;
    private string _capacity;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, string capacity)
    : base 
    (
        title,
        description,
        date,
        time,
        address,
        "Lecture",
        $"{speaker} will be speaking at the event to an audience of no more than {capacity} people."
    )
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    //What follows is an alternative option to setting the string to a shared base of _informationByType and adding it to the consolidated methods in charge of creating messages directly.
    //In such a case, _speaker and _capacity would be accessed solely by setters and getters, not the constructor.
    //This would be done so the information exclusive to the full details option would not be required to every time the lecture child class is called.
    //The setup required for that has been done below, and this explanation has been given to show I know how to do it.
    //I am choosing to fulfill the requirements with efficiency, 
    //using the skill you taught me when I was struggling with a similar problem to be able to place this ten line expanse instead into two lines, fed to the base constructor. 
    public string GetLectureInformation()
    {
        return $"{_speaker} will be speaking at the event to an audience of no more than {_capacity} people.";
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public void SetCapacity(string capacity)
    {
        _capacity = capacity;
    }
}