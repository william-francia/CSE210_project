using System;
using System.Diagnostics;


public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    
    public Activity(string name, string description)
    {
        _name = name; 
        _description = description; 
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        // ShowSpinner(3);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("You Are doing great! Well done");
        ShowSpinner(2);
        Console.WriteLine($"You completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);

    }
    public int GetDuration() => _duration;
    
    public void ShowSpinner(int seconds)
    {
        string[] symbols = {"|", "/", "-", "\\"};

        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(symbols[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}