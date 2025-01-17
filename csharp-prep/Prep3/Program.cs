using System;

class Program
{
    static void Main(string[] args)
    {
        //introduce to game, tutorial can be opted in or out.
        Console.WriteLine("Hi there! Let's play a game called hi-low!");
        Console.Write("Would you like a quick explanation on how to play? ");
        string tutorialQuestion = Console.ReadLine();
        
        //tutorial explanation of how to play
        string tutorialOptIn = tutorialQuestion.ToLower();
        if (tutorialOptIn == "y" || tutorialOptIn == "ye" || tutorialOptIn == "yes" || tutorialOptIn == "yess" || tutorialOptIn == "sure" || tutorialOptIn == "1")
        {
            Console.WriteLine("First, I will choose a number.");
            Console.WriteLine("Then, you will try to guess my number.");
            Console.WriteLine("I will give you hints with each guess, telling you whether my number is higher or lower than your current guess.");
        }
        
        //gameplay loop
        string play = "yes";
        while (play == "yes")
        {
            //pick random number

            //open another loop
            //player guesses
            //give hints


            //ask if play again
        }
    }
}