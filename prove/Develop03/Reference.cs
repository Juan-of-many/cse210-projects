using System;

public class Reference
{   
    private string _reference;

    public void SelectStartingReference(int selection)
    {
        List<string> referenceOptions =
        [
            "1 Nephi 3:7",
            "1 Nephi 21:16",
            "2 Nephi 2:25",
            "Mormon 5:23",
            "Ether 12:8-9",
            "Proverbs 3:5-6"
        ];

        //set external variable _reference to be the correlated selection index
        _reference = referenceOptions[selection];
    }
    

    public string GetReference()
    {
        return _reference;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

}