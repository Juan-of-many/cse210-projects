using System;

class Program
{
    static void Main(string[] args)
    {
        
        //setting variables here
        string play = "yes";
        string choice;
        bool wordless = false;

        //create an instance of proper class or classes
        Scripture scriptureInstance = new Scripture();

        //choose the scripture being memorized
        scriptureInstance.GenerateSelection();

        //clear screen
        Console.Clear();

        //print full, unchanged scripture
        scriptureInstance.Display(); //may need to fix
        
        //open a loop that continues until quit
        do
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

            //check if scripture is wordless
            if (scriptureInstance.IsTextIndexEmpty() == true)
            {
                wordless = true;
            }
            //else, it has data and it stays as default of false

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
            else if (wordless == true)
            {
                choice = "quit";
            }
            else
            {
                choice = "continue"; 
            }
            
            //if condition met, exit
            if (choice == "quit")
            {
                play = "no";
            }
        } while (play == "yes");
        
    }
}