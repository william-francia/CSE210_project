using System;

using System.Globalization;

public class PromptGenerator
{



public string[] numbers = new string[5];
    public string selectPrompt;

    Random randomOneToFour = new Random();
        
    
    public PromptGenerator ()
    {
        numbers[0] = "What is the most beautiful thing you spectet today?";
        numbers[1] = "What did you learn today?";
        numbers[2] = "What made you smile today?";
        numbers[3] = "What is your goal for tomorrow?";
        numbers[4] = "What happend today?";
    }

    public void Write ()
    {
        int Aleatory = randomOneToFour.Next(0, 5);
        selectPrompt = (numbers[Aleatory]);
        Console.WriteLine(selectPrompt);
    }








}