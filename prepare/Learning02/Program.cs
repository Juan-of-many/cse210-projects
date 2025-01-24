using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); //create new job instance named job1
        
        //mini test to see if Job class works.
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1;
        job1._endYear = 4;

        Job job2 = new Job(); //create a second job

        //set second job's variables
        job2._company = "Apple";
        job2._jobTitle = "Hiring Manager";
        job2._startYear = 1967;
        job2._endYear = 1988;

        //display
        job1.Display();
        job2.Display();
    }
}