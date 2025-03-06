using System;

class ListingActivity : Activity 
{
    private List<string> _listingQuestions;
    private int _itemCounter;

    public ListingActivity()
    //constructor used to construct the BreathingActivity specific items.
    //invoke the parent with base
    //pass to base the name and description.
    : base
    (
        "Listing Activity",
        "This activity can help you recognize the positive things in your life by having you list out things you appreciate and things you find comfort in."
    )
    {
        //assign variable values for constructor
        _listingQuestions =
        [
            "Who are people that you appreciate?",
            "What are you personal strengths?",
            "Who are some people you have helped out this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of the people you look up to?",
            "How have you spent time with friends or family this week?",
            "What are some of the blessings in your life?"
        ];
        _itemCounter = 0; //set to 0 at start of every call of this constructor.
    }

    public void AssembleInstructions()
    {
        //start and set and get duration
        DisplayStart();
        int duration = GetDuration();

        string question = RandomStringFromList(_listingQuestions);

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can for the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($" --- {question} --- ");

        Console.Write("You may begin in:");
        AnimationPause(2, 5); //counting backwards from 5
        Console.WriteLine();

        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        while (startTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();

            _itemCounter++;
            startTime = DateTime.Now; //exit once the time has passed, but do not cut off the person while they are typing.
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_itemCounter} items!");
        Console.WriteLine();

        DisplayEnd();
    }
}