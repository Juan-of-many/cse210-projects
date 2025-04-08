using System;

class Program
{
    static void Main(string[] args)
    {   
        //establish addresses
        Address address1 = new Address("972 Cliff Street", "Houndesly", "Washington", "USA");
        Address address2 = new Address("Wayland 4", "Glandorf", "12254", "Germany");
        Address address3 = new Address("1233 21st Street", "Paducah", "Kentucky", "USA");

        //create one event of each type and set values.
        Lecture lecture1 = new Lecture("Tom's Tea Party", "Come meet with Tom Hiddleston to learn more about the behind the scenes for the filming of The Avengers and the Loki series. Come learn what it takes to become an actor.", "10-10-2025", "1:00pm-6:00pm", address1, "Tom Hiddleston", "300");
        Reception reception1 = new Reception("Milo & Marianne's Wedding", "Milo and Marianne are getting married and have chosen to invite you! Bring a plus one or come solo. Please avoid wearing all white.", "06-01-2025", "4:15pm", address2, "MiloEveSparrow@hotmail.com");
        Outdoor outdoor1 = new Outdoor("Davenport's Earth Day Celebration", "Gather as a community to celebrate Earth Day. Pick up trash, clean up the roads, and make new friends as we take care of our planet!", "04-22-2025", "8am-8pm", address3, "crisp, yet sunny");

        //~marketing messages~
        List<string> marketingMessages = [];
        //call each of the methods to generate mock reminders as examples how a client can use this company to take care of their communications.
        //standard
        string l1Stand = lecture1.GenerateStandard();
        string r1Stand = reception1.GenerateStandard();
        string o1Stand = outdoor1.GenerateStandard();

        //full
        string l1Full = lecture1.GenerateFull();
        string r1Full = reception1.GenerateFull();
        string o1Full = outdoor1.GenerateFull();

        //short
        string l1Short = lecture1.GenerateShort();
        string r1Short = reception1.GenerateShort();
        string o1Short = outdoor1.GenerateShort();

        //add all messages to list
        marketingMessages.Add(l1Stand);
        marketingMessages.Add(r1Stand);
        marketingMessages.Add(o1Stand);
        marketingMessages.Add(l1Full);
        marketingMessages.Add(r1Full);
        marketingMessages.Add(o1Full);
        marketingMessages.Add(l1Short);
        marketingMessages.Add(r1Short);
        marketingMessages.Add(o1Short);

        //print to screen.
        foreach (string item in marketingMessages)
        {
            Console.WriteLine(item);
            Console.WriteLine();
        }
    }
}