using System;
using System.Xml.Serialization;

class Game
{
    private List<string> _notifications;
    private int _basePoints;
    
    public Game()
    {
        //point system based in 1000 points. Value can be changed, but will require the changing of other point values.
        _basePoints = 1000;
    }

    //this formula compares experience level by level
    public int CalculateLevel(int experienceAmount, int currentLevel)
    {           
        
        //formula: each level is 1000 base points plus n*100 points
        //n is current(previously achieved) level
        int experienceRequired = _basePoints + (100 * currentLevel);
        
        while (experienceAmount > experienceRequired)
        {
            //formula: experienceRequired for a singular level = 1000 + 100n
            experienceAmount = experienceAmount - experienceRequired;
            currentLevel++;

            //store the notification with the given level, choosing the mode of 0 for level-up notifications
            int mode = 0;
            
            NotificationStorage(mode, currentLevel);

            experienceRequired = _basePoints + (100 * currentLevel);
        }

        return currentLevel;
    }

    public void NotificationStorage(int mode, int levelOrMessage)
    {
        //store the notification with the given level, choosing the mode of 0 for level-up notifications
        if (mode == 0)
        {
            string notification = $"Congrats on your level up! You have reached level {levelOrMessage}!";
            _notifications.Add(notification);
        }
        //unused template for other options/modes
        else if (mode == 1)
        {
            string notification = $"text here utilizining {levelOrMessage}";
            _notifications.Add(notification);
        }
        //further notification options follow this pattern of else if, using mode, level, or other information as needed.
    }

    //responsible for reading notifications in order of when they 
    public void DisplayNotification(int amount)
    {   
        //if amount chosen is greater than the number of items in notifications, set it instead to max.
        if (amount > _notifications.Count())
        {
            amount = _notifications.Count();
        }
        
        //iterate through notifications one by one up to the amount chosen
        int i = 0;
        while (i < amount)
        {
            Console.Clear();

            Console.WriteLine($"{_notifications[i]}");
            i++;

            Console.Write("Press enter to continue: ");
            Console.ReadLine();
        }

        //need to go through and remove all the notifications just looked at.
        int j = 0;
        while (j < amount)
        {
            _notifications.RemoveAt(0); //remove very first to come up, x times, where x is amount looked at.
            j++;
        }

        int counter = _notifications.Count();
        Console.WriteLine();
        Console.WriteLine($"You have gone through {amount} notifications.");
        Console.WriteLine($"You have {counter} notifications left in your inbox.");
    }
}