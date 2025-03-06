using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        //set loop to start running, bool true
        bool run = true;
        while (run == true)
        {
            //call Menu class to create an instance, grab the menu and user input.
            Menu menuInstance = new();
            menuInstance.DisplayMenu();
            menuInstance.FixUserInput();

            //use user input to determine activity.
            int choiceIndex = menuInstance.GetMenuChoice();
            //Following is only used for testing
            /*List<string> menu = menuInstance.GetMenuOptions();
            Console.WriteLine($"{menu}")*/

            //take chosen activity by index and load into proper activity.
            if (choiceIndex == 0)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.AssembleInstructions();
            }
            else if (choiceIndex == 1)
            {
                CountdownActivity counting = new CountdownActivity();
                counting.AssembleInstructions();
            }
            else if (choiceIndex == 2)
            {
                ListingActivity listing = new ListingActivity();
                listing.AssembleInstructions();
            }
            else if (choiceIndex == 3)
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.AssembleInstructions();
            }
            else if (choiceIndex == 4)
            {
                //break loop to quit out
                run = false;
            }
            else
            {
                //error
                Console.WriteLine("Unexpected Error");
                run = false;
            }
        }

        Console.WriteLine("Thank you! Have a great time!");
    }
}