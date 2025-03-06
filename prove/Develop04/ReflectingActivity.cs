using System;

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private string _promptChoice;
    private List<string> _questions;
    private string _questionChoice;

    public ReflectingActivity()
    //constructor used to construct the BreathingActivity specific items.
    //invoke the parent with base
    //pass to base the name and description.
    : base
    (
        "Reflecting Activity",
        "This activity will help you reflect on times of your life where you have shown strength and resilience. This will lead you to better recognize the power you have that you can apply to other aspects of your life."
    )
    {
        //assign variable values for constructor
        _prompts = 
        [
            "Think of a time when you realized you were wrong and you chose to change your ways.",
            "Think of a time when you stood up for someone else.",
            "Think of a time when you accomplished something extremely difficult.",
            "Think of a time when you surpassed expectations.",
            "Think of a time when you did something genuinely selfless"
        ];
        _questions =
        [
            "Why is this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "How did you feel in the moment?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
    }

    public void AssembleInstructions()
    {
        //start and set and get duration
        DisplayStart(); //within this function, the parent variable _timeSpent is set to 0.
        int duration = GetDuration();        
        
        _promptChoice = RandomStringFromList(_prompts);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {_promptChoice} --- ");

        //duration time divided by 20 here so user gets a small buffer to think before they are given the option to press enter to skip forward.
        //multiplied by 4 because each step in the animation takes 1/4 of a second.
        AnimationPause(1, duration*4/20); 

        Console.WriteLine();
        Console.WriteLine("When you are ready, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        AnimationPause(2, 5); //version 2 being count backwards, 5 being length of time in seconds.
        
        //prepare for questioning step
        Console.Clear();
        int timeSpent = GetTimeSpent();
        int timePerQuestion = 15;

        while (timeSpent < duration)
        {
            //randomly choose a question from questions.
            _questionChoice = RandomStringFromList(_questions);
            Console.WriteLine($" --- {_questionChoice} --- ");

            AnimationPause(1, 4*timePerQuestion); //1/4 second per rotation, so 4x makes this last for 15 seconds.

            //within the loop, re-define timeSpent so it remains updated and you can have a working escape clause.
            TrackTimeSpent(timePerQuestion);
            timeSpent = GetTimeSpent(); 
        }
    
        //end
        DisplayEnd();
    }
}