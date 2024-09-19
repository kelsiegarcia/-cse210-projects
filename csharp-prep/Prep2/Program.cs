using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int gradeNumber = int.Parse(gradeString);

        string letter = "";

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber < 90 && gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber < 80 && gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber < 70 && gradeNumber >= 60)
        {
            letter = "D";
        }
        else if (gradeNumber < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is a {letter}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("You passed the course! Congrats");
        }
        else if (gradeNumber < 70)
        {
            Console.WriteLine("You did not pass the course. Please study and devote more time so you can pass!");
        }
    }

    // Console.WriteLine($"Your grade percentage is {gradeNumber} ");

}