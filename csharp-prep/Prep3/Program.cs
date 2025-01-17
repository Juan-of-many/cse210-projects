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
            Console.WriteLine("First, I will choose a number from 1-99.");
            Console.WriteLine("Then, you will try to guess my number.");
            Console.WriteLine("I will give you hints with each guess, telling you whether my number is higher or lower than your current guess.");
        }
        
        //gameplay loop
        string play = "yes";
        while (play == "yes")
        {
            //pick random number
            Random randomNumGenerator = new Random();
            int randomNum = randomNumGenerator.Next(1,99);

            Console.WriteLine($"{randomNum}");

            //create guess variable
            int guess = 0;
            int guessAmount = 0;

            //open another loop for guesses to happen inside
            do
            {
                //player guesses
                Console.Write("What is your guess? ");
                string guessUser = Console.ReadLine();

                //convert string to int
                guess = int.Parse(guessUser);

                //guess counter
                guessAmount += 1;

                //take guess and compare to our random number choice from before.
                //give hint
                if (guess > randomNum)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Congrats! You guessed it!");
                }

            } while (guess != randomNum);

            if (guessAmount == 1)
            {
                Console.WriteLine("You guessed right on your very first try!");
            }
            else
            {
               Console.WriteLine($"It only took you {guessAmount} guesses!"); 
            }
            

            //ask if play again to escape the loop
            Console.WriteLine();
            Console.Write("Would you like to continue playing? ");
            string playChoiceUser = Console.ReadLine();

            //set to lowercase to check answer. If answer doesn't include any of the affirmative responses, set play to 'no'.
            string playChoice = playChoiceUser.ToLower();
            if (!(playChoice == "y" || playChoice == "ye" || playChoice == "yes" || playChoice == "yess" || playChoice == "sure" || playChoice == "1"))
            {
                play = "no";
            }
        }
    }
}