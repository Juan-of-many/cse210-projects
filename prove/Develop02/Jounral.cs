using System;
using System.IO; //used to write text to a new file
public class Journal
{
    //create working memory to store entries.
    public string _workingMemory; //don't need to assign = "" as default value.
    
    //create an empty list of menu items named _menuOptions
    public List<string> _menuOptions = new List<string>();

    public string _userChoice;

    public string _storageLocation;


    //_workingMemory is created as an empty string outside of this function.
    //I think a function doing the same thing is obselete.
    /*public void DefineWorkingMemory()
    {
        
    }*/


    //append menu option items to _menuOptions
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
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine($"{_menuOptions[0]}");
        Console.WriteLine($"{_menuOptions[1]}");
        Console.WriteLine($"{_menuOptions[2]}");
        Console.WriteLine($"{_menuOptions[3]}");
        Console.WriteLine($"{_menuOptions[4]}");
    }

    public string GetUserChoice()
    {
        //set what will be returned.
        //It is set here to exist as an empty variable to be filled below.
        string menuChoice;

        Console.Write("What would you like to do? ");
        string userMenuChoice = Console.ReadLine();

        //attempting to change user's answer to lower-case. I hope an answer including numbers doesn't create problems.
        userMenuChoice = userMenuChoice.ToLower();
        
        //if userMenuChoice is the item, then set menuChoice to correlated pseudo-index.
        //Not real index starting at 0, perceived index shown as menu to user.
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

    public void JournalAction(string menuChoice)
    {
        if (menuChoice == "1")
        {
            //write - call the entry class and functions
            
            //it is in csv format. ~~ double tilde is to show new entry is starting.
            Entry entryInstance = new Entry();
            string entry = entryInstance.AssembleEntry();
            
            //append the value to _workingMemory. (concatenate)
            _workingMemory = _workingMemory + entry;
        }
        else if (menuChoice == "2")
        {
            //display contents of _workingMemory 
            Console.WriteLine($"{_workingMemory}");
        }
        else if (menuChoice == "3")
        {
            //load + warning if user is loading a file after writing and not yet saving
            //open a file csv and copy its contents into working memory, replacing what is currently there.
            Console.WriteLine("Warning: Opening a new file will replace any unsaved entries.");
            Console.WriteLine("Type 'y' to overwrite any unsaved progress and open a file.");
            string validator = Console.ReadLine();
            
            if (validator == "y" || validator == "Y")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                //emptying working memory before the foreach loop.
                _workingMemory = "";

                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines) //I think going line by line when I have newline instances between the prompt and answer may have caused problems with this iterating line by line?
                {
                    _workingMemory = $"{_workingMemory}{Environment.NewLine}{line}";
                }//I struggled to separate the values by the tildes when there was a new line break. The above line by line product succeeded at filling the working memory string with the correctly formatted data.
            }
        }
        else if (menuChoice == "4")
        {
            //save
            //ask for file location, then create new file with that name/location containing working memory.
            Console.WriteLine("Where would you like to save the current project?");
            _storageLocation = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(_storageLocation))
            {   
                outputFile.WriteLine($"{_workingMemory}"); 
            }
        }
        else if (menuChoice == "5")
        {
            //quit
            //break out of loop from program.cs
            //I am setting up the code in Program.cs to check at the end of every action if quit option was chosen.
            Console.WriteLine("Quitting out...");
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
