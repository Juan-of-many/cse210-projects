using System;

public class Comment
{
    private string _message; //message = comment
    private string _commenter;

    public Comment()
    {
        //calling random generators upon creation
        _message = RandomMessage();
        _commenter = RandomCommenter();
    }

    public string RandomMessage()
    {
        //pull from list of messages
        string[] messages =
        [
            "First!",
            "So inspirational!",
            "You used the wrong 'your'.",
            "Watermelon",
            "Make sure you hydrate!",
            "Checkmate!",
            "Fourth wall, prepare to be broken!",
            "Who let the dogs out?",
            "Make sure to tell Mario.",
            "Thanks!",
            "What a fun video!",
            "This... is a bucket. *gasp*",
            "We've been trying to contact you about your car's extended warranty.",
            "Why hadn't I thought of this earlier?",
            "I think I found Waldo!"
        ];
        
        var random = new Random();
        random.Next(messages.Count());
        int randomIndex = random.Next(messages.Count());
        string messageChoice = messages[randomIndex];
        return messageChoice;
    }

    public string RandomCommenter()
    {
        //pull from list of names
        List<string> names = 
        [
            "Ramona Flowers",
            "Mario Mario",
            "Luigi Mario",
            "A. Buckett",
            "Arnold Schwarzenegger",
            "Dr. Doofenshmirtz",
            "Dr. Octavius",
            "Alfred Pennyworth",
            "Gandalf, the Gray",
            "Dora, the Explorer",
            "Charlie Brown",
            "Sir Arthur Pendragon",
            "Shrek",
            "Anonymous"
        ];

        var random = new Random();
        int randomIndex = random.Next(names.Count());
        string nameChoice = names[randomIndex];
        return nameChoice;
    }

    public void DisplayCombinedComment()
    {
        // the backslash \ allows me to include quotes surrounding the commentor's message.
        string combined = $"{_commenter}: \"{_message}\"";
        Console.WriteLine($"   {combined}");
    }
}