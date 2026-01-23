using System;
using System.Globalization;

public class Entry
{

    public string _date;
    public string _prompt;
    public string _entryText;
    // desde aqui haremos el dispay

    public Entry(string date, string prompt, string entryText)
    {
        _date = date;
        _prompt = prompt;
        _entryText = entryText;

    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    public string ToSaveString()
    {
        return $"{_date}|{_prompt}|{_entryText}";
    }
}





