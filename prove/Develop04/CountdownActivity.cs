using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class CountdownActivity : Activity
{
    private List<string> _countdownInstructions;

    public CountdownActivity()
    //constructor used to construct the BreathingActivity specific items.
    //invoke the parent with base
    //pass to base the name and description.
    : base
    (
        "Countdown Activity",
        "In this activity, you will locate items around you that use your five senses. You will be guided to focus on one sense at a time, finding an amount of things that correlate to that sense."
    )
    {
        //assign variable values for constructor
        _countdownInstructions =
        [
            "Look around the room. Try to find of 5 things you can see around you.",
            "Look around the room. Try to find of 4 things you can touch around you.",
            "Look around the room. Try to find of 3 things you can hear around you.",
            "Look around the room. Try to find 2 things you can smell around you.",
            "Look around the room. Try to find 1 thing you can taste or imagine the taste of."
        ];
    }

    public void AssembleInstructions()
    {
        //start and set and get duration
        DisplayStart();
        int duration = GetDuration();        
        int i = 0;

        while (i < 5)
        {
            Console.WriteLine();
            Console.WriteLine($"{_countdownInstructions[i]}");

            //duration time separated into 5 groups, multiplied by 4 because each step in the animation takes 1/4 of a second.
            AnimationPause(1, duration*4/5); 
            Console.Write("Press enter when you are ready to continue: ");
            Console.ReadLine();

            i++;
        }
        
        //end
        DisplayEnd();
    }
}