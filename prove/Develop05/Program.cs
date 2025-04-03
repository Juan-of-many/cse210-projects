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
            //clear screen and get user input from menu
            menu.DisplayMenu();
            //at end of DisplayMenu, it asks ParseChoice to set _userChoice to proper formatted choice.
            //MenuAction takes _userChoice from the menu class to then do the correlated action.
            menu.MenuAction();
             
            
            
            //get menu choice value, check if it corresponds with the error or quit values. If so, quit. If not, continue looping.
            int choice = menu.GetUserChoice();
            if (choice == 0 || choice == 8)
            {
                play = false;
            }
        }
    }
}