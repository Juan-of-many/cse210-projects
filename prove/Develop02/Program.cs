using System;

class Program
{
    static void Main(string[] args)
    {
        //open a loop that continues accessing Menu class until user types quit as choice
        string play = "yes";

        //Working memory is established at this point. We need to not reset it every time a new action is chosen. Thus, it needs to be created outside the loop?
        //don't want multiple instances of Menu during one running of the loop over and over.
        Menu menuInstance = new Menu();
        menuInstance.AssembleMenu();

        do
        {
            menuInstance.DisplayMenu();
            
            //get the choice and place it through the menu to take the corresponding action.
            string choice = menuInstance.GetUserChoice();
            menuInstance.MenuAction(choice);

            //if choice is quit option, #5, this if statement acts as my break.
            if (choice == "5")
            {
                play = "no";
            }
        } while (play == "yes");
        
    }
}