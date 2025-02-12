using System;
using System.IO; //used to write text to a new file
public class Menu
{
    //create working memory to store entries.
    public string _workingMemory; //don't need to assign = "" as default value.
    
    //create an empty list of menu items named _menuOptions
    public List<string> _menuOptions = new List<string>();

    public string _userChoice;

    public string _storageLocation;

    //What is this?
    //_workingMemory is created as an empty string outside of this function.
    //Is it meant to assign values to working memory?
    public void DefineWorkingMemory()
    {
        
    }

    //append items to _menuOptions
    public void AssembleMenu()
    {
        _menuOptions.Add("1. Write");
        _menuOptions.Add("2. Display");
        _menuOptions.Add("3. Load");
        _menuOptions.Add("4. Save");
        _menuOptions.Add("5. Quit");
    }

    //each index number 0-4 refers to 1-5 of Write to Quit.
    public void DisplayMenu()
    {
        Console.WriteLine($"{_menuOptions[0]}");
        Console.WriteLine($"{_menuOptions[1]}");
        Console.WriteLine($"{_menuOptions[2]}");
        Console.WriteLine($"{_menuOptions[3]}");
        Console.WriteLine($"{_menuOptions[4]}");
    }

    public string GetUserChoice()
    {
        //set what will be returned as an existing and empty variable.
        string menuChoice;

        Console.Write("What would you like to do?");
        string userMenuChoice = Console.ReadLine();

        //attempting to change user's answer to lower-case. I hope an answer including numbers doesn't create problems.
        userMenuChoice = userMenuChoice.ToLower();
        
        //if userMenuChoice is the item, then set menuChoice to correlated index.
        if (userMenuChoice == "1" || userMenuChoice == "w" || userMenuChoice == "write" || userMenuChoice == "writ" || userMenuChoice == "wiret" || userMenuChoice == "wirte" || userMenuChoice == "wirt")
        {
            menuChoice = "1";   
        }
        else if (userMenuChoice == "2" || userMenuChoice == "d" || userMenuChoice == "display" || userMenuChoice == "displat" || userMenuChoice == "dipslay" || userMenuChoice == "disp")
        {
            menuChoice = "2";
        }
        else if (userMenuChoice == "3" || userMenuChoice == "l" || userMenuChoice == "load" || userMenuChoice == "loda" || userMenuChoice == "loas" || userMenuChoice == "laod")
        {
            menuChoice = "3";
        }
        else if (userMenuChoice == "4" || userMenuChoice == "s" || userMenuChoice == "save" || userMenuChoice == "svae" || userMenuChoice == "saves" || userMenuChoice == "saev")
        {
            menuChoice = "4";
        }
        else if (userMenuChoice == "5" || userMenuChoice == "q" || userMenuChoice == "quit" || userMenuChoice == "quuit" || userMenuChoice == "qiuot" || userMenuChoice == "quir")
        {
            menuChoice = "5";
        }
        else
        {
            menuChoice = "0"; //will use 0 as my error preset for this step.
        }

        return menuChoice;
    }

    public void MenuAction(string menuChoice)
    {
        if (menuChoice == "1")
        {
            //write - call the entry class and functions, returning the value to be appended to _workingMemory.
            //need to ensure it is in csv format. Thinking ~~ double tilde is good to show new entry is starting.
        }
        else if (menuChoice == "2")
        {
            //display 
            Console.WriteLine($"{_workingMemory}");
        }
        else if (menuChoice == "3")
        {
            //load + warning if user is loading a file after writing and not yet saving
            //open a file csv and copy its contents into working memory, replacing what is currently there.
            Console.WriteLine("Warning: Opening a new file will replace any unsaved entries.");

        }
        else if (menuChoice == "4")
        {
            //save
            //ask for file location, then append working memory to that location
            Console.WriteLine("Where would you like to save the current project?");
            _storageLocation = Console.ReadLine();
        }
        else if (menuChoice == "5")
        {
            //quit
            //break out of loop from program.cs

        }
        else if (menuChoice == "0")
        {
            Console.WriteLine("There appears to be a problem with what was entered or interpreted. Please try again.");
        }
        else
        {
            Console.WriteLine("Unexpected error.");
        }
    }
}
