using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); //create new job instance named job1
        //mini test to see if Job class works.
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1977;
        job1._endYear = 1984;

        Job job2 = new Job(); //create a second job
        //set second job's variables
        job2._company = "Apple";
        job2._jobTitle = "Hiring Manager";
        job2._startYear = 1989;
        job2._endYear = 2000;

        //display for step 5, final step of Job class.
        //job1.Display();
        //job2.Display();

        //now interacting with Resume class
        Resume resume1 = new Resume();
        resume1._name = "Peter Parker";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        //display for step 8, displaying information before adding the Display() function to Resume class.
        //Console.WriteLine($"{resume1._jobs[0]._jobTitle}");
        resume1.Display();
    }
}