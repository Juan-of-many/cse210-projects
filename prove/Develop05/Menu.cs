using System;
using System.Runtime;
class Menu
{
    private int _userChoice;
    private List<string> _menuOptions;
    List<string> _workingMemory;
    List<string> _profile;

    public Menu()
    {
        _workingMemory = [];
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

    public void MenuAction()
    {
        //initialize
        Game game = new Game();

        if (_userChoice == 1)
        {   
            //create new goal
            Console.WriteLine();
            Console.WriteLine("Here are your choices: ");
                
            //iterate through each, assigning a number to each item one greater than their number
            List<string> goalOptions = ["Simple Goal", "Eternal Goal", "Checklist Goal"];
            int i = 0;
            foreach (string item in goalOptions)
            {   
                i++;
                Console.WriteLine($"  {i}. {item}");
            }
            
            Console.WriteLine("What kind of goal would you like to create?");
            string rawResponse = Console.ReadLine();
            string goalResponse = rawResponse.ToLower();

            if (goalResponse == "1" || goalResponse == "s" || goalResponse == "simple goal" || goalResponse == "simple" || goalResponse == "simpel")
            {
                SimpleGoal simple = new SimpleGoal();
                string type = "simple";
                string title = simple.GetTitle();
                string description = simple.GetDescription();
                int rawPoints = simple.GetPoints();
                string points = rawPoints.ToString();
                
                string completion;
                bool completed = simple.GetComplete();
                if (completed == true)
                {
                    completion = "true";
                }
                else
                {
                    completion = "false";
                }

                string dataset = $"{type} {title} {description} {points} {completion}";
                _workingMemory.Add(dataset);
            }
            else if (goalResponse == "2" || goalResponse == "e" || goalResponse == "eternal goal" || goalResponse == "eternal")
            {
                EternalGoal eternal = new EternalGoal();
                string title = eternal.GetTitle();
                
            }
            else if (goalResponse == "3" || goalResponse == "c" || goalResponse == "checklist goal" || goalResponse == "checklist" || goalResponse == "check")
            {
                ChecklistGoal checklist = new ChecklistGoal();
                string title = checklist.GetTitle();
                
            }
            else
            {
                //invalid option selected
                Console.WriteLine("Invalid option selected. Consider using the matching number or first letter of your desired option.");
            }
        }
        else if (_userChoice == 2)
        {
            //save profile
            //ask for file location, then create new file with that name/location containing working memory.
            Console.WriteLine("What filename you would like to save this under?");
            string filename = Console.ReadLine()!.Trim();

            using(StreamWriter writeText = new StreamWriter(filename))
            {   
                writeText.WriteLine($"{_workingMemory}"); 
            }
        }
        else if (_userChoice == 3)
        {
            //load profile
            Console.WriteLine("What file would you like to open?");
            string filename = Console.ReadLine()!.Trim();

            //emptying working memory before the foreach loop.
            _workingMemory = "";
            
            //open a file csv and copy its contents into working memory, replacing previous contents.
            using(StreamReader readtext = new StreamReader(filename))
            {
                string readText = readtext.ReadLine();
            }
        }
        else if (_userChoice == 4)
        {
            //report goal progress (record event)
            //write out list of current goals
            Console.WriteLine(_workingMemory); //wip: fix _workingMemory formatting.

            //ask user for which goal they would like to report progress in, allow user to report a success in the goal, either once or multiple times.
            Console.Write("Which goal would you like to report progress in? ");
            string goalAnswer = Console.ReadLine();
            int goalTarget = Int32.Parse(goalAnswer);

            //turn goalTarget into the instance of whatever goal
            string 
            
            bool goalComplete = wip.GetComplete();

            //check if complete
            if (goalComplete == true)
            {   
                //if goal is complete, give points
                int pointValue = wip.GetPoints();
                _profile[1] = _profile[1] + pointValue;
            }
        }
        else if (_userChoice == 5)
        {
            //view goals
            Console.WriteLine(_workingMemory);//wip: fix _workingMemory formatting.
        }
        else if (_userChoice == 6)
        {
            //experience progress
            //pull the current level and exp
            string rawLevel = _profile[0];
            int level = Int32.Parse(rawLevel);
            string rawExperience = _profile[1];
            int experience = Int32.Parse(rawExperience);

            game.CalculateLevel(experience, level);
                
        }
        else if (_userChoice == 7)
        {
            //notifications (view)
            List<string> notifications = game.GetNotifications();
            int notificationCount = notifications.Count();                
            Console.WriteLine($"You have {notificationCount} notifications.");
            Console.Write("How many notifications would you like to view? ");
            string rawAmount = Console.ReadLine();
            int parsedAmount = Int32.Parse(rawAmount);
            game.DisplayNotification(parsedAmount);
        }
        else if (_userChoice == 8)
        {
            //quit
            //break is set in program, checking for 8 or 0
        }
        else if (_userChoice == 0)
        {
            Console.WriteLine("Unexpected error. Not sure how you did that.");
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