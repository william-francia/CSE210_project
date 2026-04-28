using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUserName();


        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(username, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }


    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int userNumber)
    {
        return userNumber * userNumber;
    }


    static void DisplayResult (string name, int squaredNumber)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {squaredNumber}");
    }
}