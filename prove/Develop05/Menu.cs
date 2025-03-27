using System;
class Menu
{
    private int _userChoice;
    private List<string> _menuOptions;
    private List<string> _workingMemory;

    public Menu()
    {
       _menuOptions = 
       [
            "Create new goal",
            "Save Profile",
            "Load Profile",
            "Report goal progress",
            "View goals",
            "Experience Progress",
            "Notifications",
            "Quit"
       ];
    }

    public void DisplayMenu()
    {   
        //wipe screen
        Console.Clear();

        //header
        Console.WriteLine("Menu Options:");
        //iterate through each, assigning a number to each item one greater than their number
        int i = 0;
        foreach (string item in _menuOptions)
        {   
            i++;
            Console.WriteLine($"  {i}. {item}");

        }
        //last option is quit
        //all options are indented by two spaces

        //ask for user input
        Console.Write("Select a choice from the menu: ");
        
        //once input has been received, call ParseChoice to fix formatting
        string choice = Console.ReadLine();
        ParseChoice(choice);
    }

    public void ParseChoice(string choice)
    {
        choice = choice.ToLower();
        if (choice == "1" || choice == "c" || choice == "create new" || choice == "create goal" || choice == "create" || choice == "crate" || choice == "creta" || choice == "cre" || choice == "cr")
        {
            _userChoice = 1;   
        }
        else if (choice == "2" || choice == "s" || choice == "save profile" || choice == "save p" || choice == "save" || choice == "save ")
        {
            _userChoice = 2;
        }
        else if (choice == "3" || choice == "l" || choice == "load profile" || choice == "loda" || choice == "load" || choice == "load p" || choice == "load pro")
        {
            _userChoice = 3;
        }
        else if (choice == "4" || choice == "r" || choice == "goal progress" || choice == "report goal progress" || choice == "report goal" || choice == "report" || choice == "rpe" || choice == "re" || choice == "repo")
        {
            _userChoice = 4;
        }
        else if (choice == "5" || choice == "v" || choice == "view goals" || choice == "view" || choice == "view goal" || choice == "vi" || choice == "view golas")
        {
            _userChoice = 5;
        }
        else if (choice == "6" || choice == "e" || choice == "experience progress" || choice == "exp progress" || choice == "experience" || choice == "exp pro" || choice == "exp" || choice == "xp" || choice == "x" || choice == "ep")
        {
            _userChoice = 6;
        }
        else if (choice == "7" || choice == "n" || choice == "no" || choice == "not" || choice == "note" || choice == "notif" || choice == "notification" || choice == "notifications")
        {
            _userChoice = 7;
        }
        else if (choice == "8" || choice == "q" || choice == "quit" || choice == "quuit" || choice == "qiuot" || choice == "quir" || choice == "qu" || choice == "qq")
        {
            _userChoice = 8;
        }
        else
        {
            _userChoice = 0; //will use 0 as my error value for this step.
        }
    }

    public int GetUserChoice()
    {
        return _userChoice;
    }

    public List<string> GetMenuOptions()
    {
        return _menuOptions;
    }

    
}