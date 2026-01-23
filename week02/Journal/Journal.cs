using System;
using System.IO.Enumeration;
using System.IO;
using System.Collections.Generic;



public class Journal
{


    public List<Entry> _entries = new List<Entry>();



    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))

        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToSaveString());
            }

        }

    }
public void Load(string filename)
{
    _entries.Clear();

    string[] lines = File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split("|");

        string date = parts[0];
        string prompt = parts[1];
        string text = parts[2];

        Entry entry = new Entry(date, prompt, text);
        _entries.Add(entry);
    }
}




}