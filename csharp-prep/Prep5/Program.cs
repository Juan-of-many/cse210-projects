using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    
    static void DisplayWelcome()
        {
            // function_body
            Console.WriteLine("Welcome to the program!");
        }

    static string PromptUserName()
        {
            //function_body
            Console.Write("Please enter your name or pseudonym: ");
            string localUserName = Console.ReadLine();

            return localUserName;
        }
    
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string localUserChoice = Console.ReadLine();
        int localUserNumber = int.Parse(localUserChoice);
        
        return localUserNumber;
    }

    static int SquareNumber(int num)
    {
        int squared = num * num;

        return squared;
    }

    static void DisplayResult(string userName, int squaredNum)
    {
        Console.Write($"{userName}, the square of your number is {squaredNum}");
    }
}
