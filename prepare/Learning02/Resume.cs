using System;

public class Resume
{
    public string _name; //don't need to assign = "" as default value.
    public List<Job> _jobs = new List<Job>(); 
    //I think List<Job> tells the code there will be a list datatype holding inside it instances of Job.
    //and = new List<Job>() maybe tells the program a new list is to be created, not to search for an existing one.

    public void Display()
    {
        Console.WriteLine($"Name: {_name}"); //any time a name is given for the display command to check, it will print the name and then continue by printing the list of jobs that correspond with that name.
        Console.WriteLine("Jobs: ");

        //for each individual item in the _jobs list for this individual (see below for continuation)
        foreach (Job job in _jobs) 
        {
            job.Display(); //call the Job class display for the current position 'job' to print all the job's details.
        }
    }
}







//Responsibilities: Keeps track of the person's name and a list of their jobs.
//Behaviors: Displays the resume, which shows the name first, followed by displaying each one of the jobs.

//_name string
//_jobs list<Job>

//Display() void
