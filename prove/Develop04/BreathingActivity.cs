using System;
using System.Diagnostics;

class BreathingActivity : Activity
{
    //declare variables for breathing
    private string _breathingInstructions;
    private bool _Switch;
    private int _breathingTimer;

    public BreathingActivity()
    //constructor used to construct the BreathingActivity specific items.
    //invoke the parent with base
    //pass to base the name and description.
    : base
    (
        "Breathing Activity",
        "This is a guided breathing exercise. It can help you relax as you follow along, breathing in and out as instructed. Focus on the pattern of your breathing."
    )
    {
        _Switch = false;
        //_breathingInstructions is set as nothing, could set it to something, if an error is raised due to it being unassigned.
    }

    public void AssembleInstructions()
    {
        //start and set duration
        DisplayStart();
        
        //load in
        AnimationPause(0);

        //set loop play condition to true.
        bool play = true;
        //set timeSpent to 0
        SetTimeSpent(0);
        //get duration goal that was set in DisplayStart
        int duration = GetDuration();
        
        //open loop for alternating breathing instructions to breathe in and out
        while (play == true)
        {
            //set timer to starting value, 4 sec or 6 sec respectively
            //also set breathingInstructions to in or out.
            SwitchManager();
            Console.WriteLine($"{_breathingInstructions}");

            //using the timer set directly above, determine the amount of time that will be dedicated to each breath in and out.
            //use TrackTimeSpent to add that time to the running total.
            TrackTimeSpent(_breathingTimer);

            //keep rewriting and replacing the number as time passes, 1 sec per sec.
            while (_breathingTimer > 0)
            {
                Console.Write($"{_breathingTimer}");
                
                //sleep for 1 sec
                Thread.Sleep(1000);

                //track the passage of time, 1000ms sleep is 1 sec
                _breathingTimer--;

                //erase, preparing for loop around or exit
                //this moves the cursor left, types the space key, then moves left once more, a roundabout way to erase one character.
                Console.Write("\b \b");
            }

            //get the value of current running total of timeSpent to be compared to duration.
            int timeSpent = GetTimeSpent();

            //end clause requires both the duration time to be surpassed or perfectly met, and to end with a full cycle.
            //No ending with a breath in, always ending with a breath out. (_Switch == false)
            if (timeSpent >= duration && _Switch == false)
            {
                play = false;
            }
        }

        //end
        DisplayEnd();

    }

    public void SwitchManager()
    {
        //if last action was to breathe in (switch is true), exhale + flip switch to false
        if (_Switch == false)
        {
            _breathingInstructions = "Breathe in...";
            _breathingTimer = 4;
            _Switch = true;
        }
        //else: last action was breathe out (switch is false) || or last action does not exist at start, inhale + flip switch to trues
        else if (_Switch == true)
        {
            _breathingInstructions = "Breathe out...";
            _breathingTimer = 6;
            _Switch = false;
        }
    }
}