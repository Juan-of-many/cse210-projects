using System;
using System.Drawing;

class Reception : Event
{
    private string _reserveEmail;
    public Reception(string title, string description, string date, string time, Address address, string reserveEmail)
    : base 
    (
        title,
        description,
        date,
        time,
        address,
        "Reception",
        $"Whether you decide to attend or not, please send an email to {reserveEmail} to let us know if we should expect you."
    )
    {
        _reserveEmail = reserveEmail;
    }

    //What follows is an alternative option to setting the string to a shared base of _informationByType and adding it to the consolidated methods in charge of creating the messages directly.
    //For the Reception class, the _reserveEmail would be accessed solely by setters and getters, not the constructor.
    //This is so a user wanting to create only a short or standard description does not need to provide the extra information required exclusively by the full description option.
    //The setup required for that has been written out below, and this explanation has been given to show my understanding.

    //With how I have programmed this assignment, an event-planning company can acquire all the details of the event, 
    //submit them all at once into the program, and generate any selection of the three levels of detailed description options they have at hand.
    //From how I understand the prompt, this fits with the companies requirements better than the alternative.

    //That said, here is the setup for the alternative solution.
    public string GetReserveMessage()
    {
        string reserveMessage = $"Whether you decide to attend or not, please send an email to {_reserveEmail} to let us know if we should expect you.";
        return reserveMessage;
    }
    public void SetReserveEmail(string reserveEmail)
    {
        _reserveEmail = reserveEmail;
    }
}