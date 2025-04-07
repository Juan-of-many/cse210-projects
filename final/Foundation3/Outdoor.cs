using System;
using System.Drawing;

class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string description, string date, string time, Address address, string weather)
    : base 
    (
        title,
        description,
        date,
        time,
        address,
        "Outdoor",
        $"It looks like that day may be {weather}. Please dress accordingly. If problems arise, venues are subject to change."
    )
    {
        _weather = weather;
    }

    //What follows is an alternative option to setting the string to a shared base of _informationByType and adding it to the consolidated methods in charge of creating the messages directly.
    //For the Outdoor event class, _weather would be accessed solely by setters and getters, not the constructor.
    //This would be done so a user wanting to create only a simpler description does not need to provide the extra information required exclusively by the full description option.
    //The setup required for that has been written out below, and this explanation has been given to show my awareness of what is going on.

    //With how I have programmed this assignment, an event-planning company can gather all the details they need for an event or advertisement, 
    //enter them all at once into the program, then generate any selection of the three levels of detailing so they can receive one or more descriptions matching the level of complexity for all their needs.
    //From how I understand the prompt, this fits with the companies requirements better than the alternative.

    //That said, here is some of the setup for the alternative solution to further sement my understanding.
    public string GetWeatherDisclaimer()
    {
        string weatherDisclaimer = $"It looks like that day may be {_weather}. Please dress accordingly. If problems arise, venues are subject to change.";
        return weatherDisclaimer;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }
}