using System;

//Hi, I am a test note/comment
/*me
too */

class Program
{
    static void Main(string[] args)
    {
        //get user input for first and last name.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        
        //print user input results in fancy James Bond format.
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}