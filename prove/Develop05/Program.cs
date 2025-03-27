using System;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        //load in, create and call the menu
        Menu menu = new Menu();
        
        bool play = true;
        while (play == true)
        {
            //get user input from menu
            menu.DisplayMenu();
            
            //retrieve the properly formatted choice and menu
            int choiceValue = menu.GetUserChoice(); 
            List<string> menuOptions = menu.GetMenuOptions();
            
            if (choiceValue == 1)
            {
                //create new goal
            }
            else if (choiceValue == 2)
            {
                //save profile
            }
            else if (choiceValue == 3)
            {
                //load profile
            }
            else if (choiceValue == 4)
            {
                //report goal progress
            }
            else if (choiceValue == 5)
            {
                //view goals
            }
            else if (choiceValue == 6)
            {
                //experience progress
            }
            else if (choiceValue == 7)
            {
                //notifications
            }
            else if (choiceValue == 8)
            {
                //quit
                play = false;
            }
            else if (choiceValue == 0)
            {
                Console.WriteLine("Unexpected error. Not sure how you did that.");
                play = false;
            }
        }

        string title;
        string description;
        int points;
        Goal g = new Goal(title, description, points);
        }
    }
}