using System;
using System.ComponentModel.Design;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        //create empty list for numerals
        List<int> numerals = new List<int>();
        
        int userNumber = 1; //default set to not cause false positive.

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            //ask for numbers to fill numerals list
            Console.Write("Please enter a number: ");
            string userNumberChoice = Console.ReadLine();

            //convert string to int
            userNumber = int.Parse(userNumberChoice);
            numerals.Add(userNumber);

        } while (userNumber != 0);

        //remove the 0 because it is not meant to be part of the list
        numerals.RemoveAt(numerals.Count -1);

        //math time for sum and avg (getting amount)
        int sum = 0;
        int amount = 0;
        foreach (int i in numerals)
        {
            sum += i; //add the current number, i, to do the maths to add all together
            amount += 1;
        }

        //avg
        float avg = sum / amount;

        //max
        int champion = 0;
        foreach (int j in numerals)
        {
            if (j > champion)
            {
                //set current number to max if it is larger than previous champion max.
                champion = j;
            }
        }
        
        //print out results
        Console.WriteLine();
        Console.WriteLine($"Your sum is: {sum}");
        Console.WriteLine($"Your average is: {avg}");
        Console.WriteLine($"Your max is: {champion}");
    }
}