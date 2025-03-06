using System;

class Menu
{
    private string _userChoice;
    private int _menuChoice;
    private List<string> _menuOptions;

    public Menu()
    {
       _menuOptions = 
       [
            "Start breathing activity",
            "Start countdown activity",
            "Start listing activity",
            "Start reflecting activity",
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
        _userChoice = Console.ReadLine();
    }
    
    //only to be run after DisplayMenu, purpose of standardizing user input to preferred format.
    //If any options are added, this will need to be updated to fit those options.
    public void FixUserInput()
    {
        //set to lower case
        _userChoice = _userChoice.ToLower();

        //set userchoice and menuchoice to both be a string number matching the decision.
        //_menuChoice is set to match the index position, one less than printed position.
        if ( _userChoice == "1" || _userChoice == "start breathing activity" || _userChoice == "b" || _userChoice == "br" || _userChoice == "bre" || _userChoice == "breath" || _userChoice == "breathing" || _userChoice == "breathe" || _userChoice == "breathing activity")
        {
            _userChoice = "1";
            _menuChoice = 0;
        }
        else if (_userChoice == "2" || _userChoice == "start countdown activity" || _userChoice == "c" || _userChoice == "co" || _userChoice == "cd" || _userChoice == "count" || _userChoice == "countdown" || _userChoice == "countdown activity")
        {
            _userChoice = "2";
            _menuChoice = 1;
        }
        else if (_userChoice == "3" || _userChoice == "start listing activity" || _userChoice == "l" || _userChoice == "li" || _userChoice == "lis" || _userChoice == "list" || _userChoice == "listing" || _userChoice == "listing activity")
        {
            _userChoice = "3";
            _menuChoice = 2;
        }
        else if (_userChoice == "4" || _userChoice == "start reflecting activity" || _userChoice == "r" || _userChoice == "re" || _userChoice == "ref" || _userChoice == "reflect" || _userChoice == "reflecting" || _userChoice == "reflecting activity")
        {
            _userChoice = "4";
            _menuChoice = 3;
        }
        else if (_userChoice == "5" || _userChoice == "quit" || _userChoice == "q" || _userChoice == "qu" || _userChoice == "qui" || _userChoice == "qq")
        {
            _userChoice = "5";
            _menuChoice = 4;
        }
        else
        {   
            //user entered something wrong or error
            Console.WriteLine("Please try entering something different.");
            Console.Write("Press enter when you are ready to continue: ");
            Console.ReadLine();

            //this is a way to create a loop until a valid choice is chosen.
            DisplayMenu();
            FixUserInput();
        }
    }

    public int GetMenuChoice()
    {
        return _menuChoice;
    }

    public List<string> GetMenuOptions()
    {
        return _menuOptions;
    }
}