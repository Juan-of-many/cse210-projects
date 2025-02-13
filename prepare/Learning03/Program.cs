using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction();
        Fraction test2 = new Fraction(5);
        Fraction test3 = new Fraction(3,4);
        Fraction test4 = new Fraction(1,3);

        Console.WriteLine(test1.GetFractionString());
        Console.WriteLine(test1.GetDecimalValue());

        Console.WriteLine($"{test2.GetFractionString()}");
        Console.WriteLine($"{test2.GetDecimalValue()}");

        string stringtest = test3.GetFractionString();
        double doubletest = test3.GetDecimalValue();
        Console.WriteLine(stringtest);
        Console.WriteLine(doubletest);

        Console.WriteLine(test4.GetFractionString());
        Console.WriteLine(test4.GetDecimalValue());


        //setters and getters practice
        /*
        test1.SetTop(4);
        test1.SetBottom(4);
        int toptest1 = test1.GetTop();
        int bottomtest1 = test1.GetBottom();
        Console.WriteLine($"{toptest1}/{bottomtest1}");
        
        test2.SetTop(3);
        test2.SetBottom(4);
        int toptest2 = test2.GetTop();
        int bottomtest2 = test2.GetBottom();
        Console.WriteLine($"{toptest2}/{bottomtest2}");

        test3.SetTop(7);
        test3.SetBottom(7);
        int toptest3 = test3.GetTop();
        int bottomtest3 = test3.GetBottom();
        Console.WriteLine($"{toptest3}/{bottomtest3}");
        */
    }
}