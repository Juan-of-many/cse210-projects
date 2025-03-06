using System;
using System.ComponentModel.DataAnnotations;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    private int _timeSpent;

    public Activity(string name, string description)
    {
        //set defaults. This constructor does not feel like it is doing anything useful.
        _activityName = name;
        _description = description;
        _duration = 50; //default is overwritten, this is here as a safety measure
    }

    public void DisplayStart() //this starts off all activities and sets the duration
    {
        Console.Clear();
        
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like your session to last? ");
        string rawDuration = Console.ReadLine();
        _duration = Int32.Parse(rawDuration);

        //load in with animation version 0, length of 16 for the i range, 4 secs
        //AnimationPause clears the screen at this point.
        AnimationPause(0, 16);

        //set timeSpent to 0
        SetTimeSpent(0);
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void SetTimeSpent(int value)
    {
        _timeSpent = value;
    }

    public void TrackTimeSpent(int time)
    {   
        //add the time that has passed to _timeSpent
        _timeSpent += time;
    }
    public int GetTimeSpent()
    {
        return _timeSpent;
    }

    public string RandomStringFromList(List<string> items)
    {
        //create an instance of random.
        var random = new Random();

        //use random to generate a number within the length of the number of items in the provided list.
        int randomIndex = random.Next(items.Count());
        
        //because the number was generated using the total length of the list,
        //and the counting starts at 1, we need to reduce that number by 1 to fit within the confines of the index that matches that list.
        //randomIndex = randomIndex - 1;
        //I appear to be wrong. randomIndex has a value in the place of index 0 without altering it. 

        //pull from the list at that index value to retrieve the text string we want to return.
        string randomItem = items[randomIndex];
        return randomItem;
    }
    
    public void AnimationPause(int version, int length)
    {
        //this is the pause/loading animation
        if (version == 0)
        {
            Console.Clear();
            Console.WriteLine("Get ready...");

            int i = 0;
            List<string> spinList =
            [
                "|", "/", "-", """\"""
            ];

            while (i < length)
            {   
                //remainder of i divided by number of items in index = position of current item.
                Console.Write($"{spinList[i % 4]}");
                
                //sleep for 1/4 sec
                Thread.Sleep(250);

                //erase, preparing for loop around or exit
                //this moves the cursor left, types the space key, then moves left once more, a roundabout way to erase one character.
                Console.Write("\b \b");

                i++;
            }    
        }
        //version 1 is like version 0 but does not clear screen or give a readying instruction
        else if (version == 1)
        {
            int j = 0;
            List<string> spinList =
            [
                "|", "/", "-", """\"""
            ];

            while (j < length)
            {   
                //remainder of i divided by number of items in index = position of current item.
                Console.Write($"{spinList[j % 4]}");
                
                //sleep for 1/4 sec
                Thread.Sleep(250);

                //erase, preparing for loop around or exit
                //this moves the cursor left, types the space key, then moves left once more, a roundabout way to erase one character.
                Console.Write("\b \b");

                j++;
            }    
        }
        //version 2 is completely different from 0 and 1, it counts backwards from the value given in 'length' all the way to 1, where it finishes.
        else if (version == 2)
        {   
            List<int> numbers = []; //create empty numbers list

            //set k to the length, for as long as k remains above 0, increment by -1 and do what is inside the curly brackets.
            for (int k = length; k > 0; k--)
            {
                //fill list with k counting down from length to 1, cutting off before 0
                numbers.Add(k);
            }
            
            //set l to 0 to be used to track the number of iterations.
            int l = 0;
            while (l < length)
            {   
                //print the current number descending from the maximum number that was provided as length to 1.
                Console.Write($"{numbers[l]}");

                //sleep for 1 sec
                Thread.Sleep(1000);

                //move cursor left, type the space key, then move the cursor left
                //roundabout way to erase, preparing for loop around or exit
                Console.Write("\b \b");

                l++;
            }
        }
    }

    public void DisplayEnd()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        AnimationPause(1, 12);

        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName}!");
        AnimationPause(1, 20);
    }
}