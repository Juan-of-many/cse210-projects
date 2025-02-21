using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("jorge", "algebra");

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment maths1 = new MathAssignment("Jorge Herrans", "Geometry", "4.2", "10-24");
        Console.WriteLine(maths1.GetSummary());
        Console.WriteLine(maths1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment paper1 = new WritingAssignment("Sarah Williams", "Film and Game Studies", "The History of Speedrunning Donkey Kong");
        Console.WriteLine(paper1.GetSummary());
        Console.WriteLine(paper1.GetWritingInformation());
    }
}