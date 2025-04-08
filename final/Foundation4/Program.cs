using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //create empty list
        List<Activity> activities = [];

        //create activities
        RunningActivity running = new RunningActivity("03 Nov 2022", 30, 3);
        BicycleActivity cycling = new BicycleActivity("03 Nov 2022", 60, 10);
        SwimmingActivity swimming = new SwimmingActivity("03 Nov 2022", 90, 21);
        
        //fill activity list
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        //foreach item in list, get and print summary
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        
    }
}