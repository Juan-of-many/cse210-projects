using System;

class Program
{
    static void Main(string[] args)
    {
        //setting variables here
        string play = "yes";
        string choice;

        //create an instance of proper class or classes
        Scripture scriptureInstance = new Scripture();

        //choose the scripture being memorized
        scriptureInstance.GenerateSelection();

        //turn the selection into something usable with my Display function, which calls the compiler to get the scripture text.
        scriptureInstance.PhraseIntoWord();

        //clear screen
        Console.Clear();

        //print full, unchanged scripture
        scriptureInstance.Display();

        //determine choice, asking user if they wish to continue
        choice = GetUserChoice();
            
        //if condition met, exit
        if (choice == "quit")
        {
            play = "no";
        }
        
        //set the index to match starting scripture, needing PhraseIntoWord above it to set formatting properly
        scriptureInstance.SetStartingIndex();
        
        //open a loop that continues until quit or empty
        while (play == "yes")
        {
            //alter scripture x times, in this case 3 words are removed
            int x = 3;
            int i = 0;
            while (i < x)
            {
                scriptureInstance.ReplaceWord();
                i++;
            }

            //clear screen
            Console.Clear();

            //print scripture in current form
            scriptureInstance.Display();

            choice = GetUserChoice();

            //check if scripture is wordless
            if (scriptureInstance.IsTextIndexEmpty() == true)
            {   
                //wordless is true, so choice = "quit", regardless of what user chose above.
                //wordless = true;
                choice = "quit";
            }
            //else, it has data and it stays as default of false or user's choice.

            //if exit condition of choice being quit or wordless being true met, exit
            if (choice == "quit")
            {
                play = "no";
            }
        }
        
    }


    //simplify code by splitting into functions
    static string GetUserChoice()
    {
        //set return variable
        string choice;

        //prompt user to continue, with polite whitespace for formatting
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string userChoice = Console.ReadLine();

        //fix formatting of userChoice
        string lowerChoice = userChoice.ToLower();

        //determine if quit
        if (lowerChoice == "q" || lowerChoice == "qq" || lowerChoice == "quit" || lowerChoice == "0")
        {
            choice = "quit";
        }
        else
        {
            choice = "continue"; 
        }

        return choice;
    }
}