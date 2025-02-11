using System;

public class Prompt
{
    //Create list, public if I want it to be able to be changed and accessed by others. Not necessary yet, but could be useful potentially.
    List<string> prompts =
    [
        //add elements format listname.Add(item);
        "What is the best thing you ate today?",
        "What is a strange thing that happened to you recently?",
        "What is something cool you experienced",
        "If you were an animal, what kind of animal would you be?",
        "If you could have any super power, what would it be?",
        "If you found a genie, what would your 3 wishes be?",
        "How would you spend 1 million dollars?",
        "If you could spend a day with one person (dead or alive), who would it be?",
        "What is your favorite number in the Fibonacci Sequence?",
        "What side characters in a book or movie should star in their own spin-off?",
        "Who *really* let the dogs out?",
        "What *does* the fox say?",
        "Would you rather be unable to walk or unable to see?",
        "Do you need to vent anything?",
        "Describe your perfect day.",
        "Describe your mental state.",
        "What questions should we add to our prompt list?"
    ];  

    //Because I created the list above in Prompt.cs, 
    //I do not believe there are any problems with the following GeneratePrompt function calling prompts to return a singular prompt from the list.
    //If something breaks, however, I could see GeneratePrompt needing a parameter to store the argument of the prompts list.
    public string GeneratePrompt() 
    {
        //create random generator.
        //create a variable called index.
        //use .Next to choose a number from 0 to n to set as the current index, n being essentially the value of the index location of the final prompt.
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(prompts.Count);

        //ask prompts list to give the information stored in that index position.
        string promptChoice = prompts[index];
        
        //return that prompt information to whatever called this prompts class.
        return promptChoice;
    }
}