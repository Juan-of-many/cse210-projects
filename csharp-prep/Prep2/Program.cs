using System;

class Program
{
    static void Main(string[] args)
    {
        //declare variable(s)
        string gradeLetter = ""; //Is there any need to be doing this? What safety measure does this add? Does it make the code break less if the user types something like "90.98" or "chicken"?
        string gradeModifier = "";

        //get user input of grade
        Console.Write("Hi there! What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        Console.WriteLine(""); //one more line of personal space for user-friendliness
        
        //convert string to int
        int gradeNumber = int.Parse(userGrade);

        //compare numerical grade to letter-grade on Grading Scale found below.
        //set appropriate letter-grade. 
        if (gradeNumber >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeNumber >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNumber >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNumber >= 60)
        {
            gradeLetter = "D";
        }
        else if (gradeNumber < 60)
        {
            gradeLetter = "F";
        }
        else
        {
            Console.WriteLine("There appears to be an error related to the user's entered grade.");
            //gradeLetter remains at its default of ""
        }

        //Determine + or - modifiers to grades, first excluding A+, then excluding F+ and F-
        if (gradeLetter == "A") //if the letter grade is an A
        {
            if (gradeNumber % 10 < 3)
            {
                gradeModifier = "-";
            }
            else
            {
                gradeModifier = ""; //unchanged from default
            }
        }
        else if (gradeLetter != "F") //so long as the letter grade is not an F
        {
            if (gradeNumber % 10 >= 7)
            {
                gradeModifier = "+";
            }
            else if (gradeNumber % 10 < 3)
            {
                gradeModifier = "-";
            }
            else
            {
                gradeModifier = ""; //unchanged from default
            }
        }
        else
        {
            gradeModifier = ""; //unchanged from default if gradeLetter is an F
        }
            

        //Break of sorts if the user's input was improperly formatted or some other error occurred.
        if (gradeLetter == "")
        {
            Console.WriteLine("There appears to be an error related to the conversion of the user's grade.");
        }
        //If all is running properly, print to screen the user's grade.
        else
        {
            Console.WriteLine($"Your grade is: {gradeLetter}" + $"{gradeModifier}");

            //check if user passed or failed and respond accordingly.
            if (gradeLetter == "A" || gradeLetter == "B" || gradeLetter == "C")
            {
                Console.WriteLine("Congratulations on passing!");
            }
            else
            {
                Console.WriteLine("You didn't quite pass. This isn't the end of the world.");
                Console.WriteLine(); //extra space for dyslexia readability.
                Console.WriteLine("Hopefully you have learned something new and can take that knowledge with you, whether you choose to retake the course or move on.");
            }
        }

        
        /*
        Grading Scale:
        A >= 90
        B >= 80
        C >= 70
        D >= 60
        F < 60
        */
    }
}