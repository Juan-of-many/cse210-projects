using System;

public class Entry
{
    //declare variables
    string _prompt;
    string _userResponse;
    string _date;
    string _entry;
    
    static string GetDateTime() 
    {
        DateTime currentTime = DateTime.Now;
        string date = currentTime.ToShortDateString();
        
        return date;
    }

    static string GetPrompt()
    {
        Prompt promptInstance = new Prompt();
        string prompt = promptInstance.GeneratePrompt();
        
        return prompt;
    }

    static string GetResponse(string prompt)
    {
        Console.WriteLine($"{prompt}");
        string response = Console.ReadLine();

        return response;
    }

    //call all functions to generate and assemble the parts in the right order.
    public string AssembleEntry()
    {
        _date = GetDateTime();
        _prompt = GetPrompt();
        _userResponse = GetResponse(_prompt);

        _entry = $"~~{_date}: {_prompt}{Environment.NewLine}{_userResponse}{Environment.NewLine}";
        return _entry;
    }
}