using System;
using System.Formats.Asn1;

public class Scripture
{
    //foreach word in the scripture text, create an instance of the Word class object.
    
    //create variable to hold scripture text content
    private int _selection;
    private string _text;
    private List<int> _textIndex;
    private string[] _words;

    public void GenerateSelection()
    {
        //random choice of index within range of the options available
        //setting _selection to be that result.
        Random random = new Random();
        _selection = random.Next(0,5);

        //give generated number to selectors to acquire matching scripture and reference 
        SelectStartingText(_selection); 
    }

    //acquire scripture
    public void SelectStartingText(int selection)
    {
        List<string> textOptions =
        [
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
            "Behold, I have graven thee upon the palms of my hands.",
            "Adam fell that men might be; and men are, that they might have joy.",
            "Know ye not that ye are in the hands of God? Know ye not that he hath all power, and at his great command the earth shall be rolled together as a scroll?",
            "But because of the faith of men he has shown himself unto the world, and glorified the name of the Father, and prepared a way that thereby others might be partakers of the heavenly gift, that they might hope for those things which they have not seen; Wherefore, ye may also have hope, and be partakers of the gift, if ye will but have faith.",
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths."
        ];

        //set external variable _text to be the result
        _text = textOptions[selection];
    }

    //split the scripture text into an array of single words
    public void PhraseIntoWord()
    {
        string[] words = _text.Split(" ");//separate each word from another. 

        _words = words;
    }

    //need to call this only once per scripture. this creates the starting index.
    //sets up the check in GenerateRandom to see if an item has been changed.
    public void SetStartingIndex()
    {
        List<int> nums = new();

        for (int i = 0; i < _words.Length; i++)
        {
            nums.Add(i);
        }
        _textIndex = nums;
    }

    //call this function x times, where x is the number of words to be removed.
    //This generates the position of a remaining word.
    //It will be used to identify which words have been changed and which have not been changed.
    public void ReplaceWord()
    {   
        //the scope of the random choice is from 0, the first index position, to the last index position.
        //I can acquire that same last index position by finding the length and subtracting one using the listname.Count feature.
       int length = _textIndex.Count;
       int scope = length - 1; //needed because indexes start at 0.

        //call random to find target by position in remaining words.
        int targetIndex = GenerateRandom(scope);
        
        //compare that position with remaining words
        int assassin = _textIndex[targetIndex];

        //talk to Word.cs, change targetted word out for ___. This follows encapsulation rules because of the way it pokes the Word.cs file. 
        //If ___ was deemed unsuitable and someone wanted to change the word to anything else, it will still function, as this checks if it has been changed, not what it has been changed to.
        Word wordInstance = new Word();
        _words[assassin] = wordInstance.Replace();
        
        //remove that chosen option from future possibilities
        _textIndex.RemoveAt(targetIndex);
        //I shouldn't need to set _textIndex = _textIndex to tell it it has had an item removed.
    }

    public int GenerateRandom(int scope)
    {
        //pick a word within the scope of length of _textIndex 
        Random random = new Random();
        int randomTarget = random.Next(0,scope);

        return randomTarget;
    }

    public void AssembleText()
    {
        //empty _text from previous form to be replaced with new changes included
        _text = "";
        for (int i = 0; i < _words.Length; i++)
        {
            //add each word one by one in order, at position of i
            _text = $"{_text} {_words[i]}";
        }
    }

    public void Display()
    {
        //Create the instance of the object that will be used to provide our reference.
        Reference referenceInstance = new Reference();
        referenceInstance.SelectStartingReference(_selection);
        
        //ensure reference and text are ready to be displayed
        string reference = referenceInstance.GetReference();
        AssembleText();
        
        Console.WriteLine($"{reference} {_text}");
    }

    public bool IsTextIndexEmpty()
    {
        if (_textIndex.Count == 0)
        {   
            bool answer = true; //empty
            return answer;
        }
        else
        {
            bool answer = false; //not empty
            return answer;
        }
    }
}