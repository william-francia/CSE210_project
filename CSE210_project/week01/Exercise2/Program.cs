using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine ($"Your grade is {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulation, keep doing like this and better, you can give more like this.");
        }
        else
        {
            Console.WriteLine("We appologize, you have to repit the course.");
        }
    }
}