using System;
using System.Diagnostics;

class BreathingActivity : Activity
{
    //declare variables for breathing
    private string _breathingInstructions;
    private bool _breathingSwitch;
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
        _breathingSwitch = false;
        //_breathingInstructions is set as nothing, could set it to something, if an error is raised due to it being unassigned.
    }

    public void AssembleInstructions()
    {
        //start and set duration
        DisplayStart();
        
        //load in
        AnimationPause(0);

        bool play = true;

        //set timeSpent to 0


        //open loop for alternating breathing instructions to breathe in and out
        //will stop only on breathe out and once time falls below 2 seconds
        while (play == true)
        {
            //set timer to starting value, 4 sec or 6 sec respectively
            //also set breathingInstructions to in or out.
            SwitchManager();
            Console.WriteLine($"{_breathingInstructions}");

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

                GetTimeSpent();
            }


            if (conditionMet == true)
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
        if (_breathingSwitch == false)
        {
            _breathingInstructions = "Breathe in...";
            _breathingTimer = 4;
            _breathingSwitch = true;
        }
        //else: last action was breathe out (switch is false) || or last action does not exist at start, inhale + flip switch to trues
        else if (_breathingSwitch == true)
        {
            _breathingInstructions = "Breathe out...";
            _breathingTimer = 6;
            _breathingSwitch = false;
        }
    }
}