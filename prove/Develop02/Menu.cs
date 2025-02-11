using System;

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

    public void MenuAction()
    {
        
    }
}
