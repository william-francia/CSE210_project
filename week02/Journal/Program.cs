using System;
using System.Data;

public class Program
{
    static void Main(string[] args)
    {
        int Response = 0;
        bool CorrectResponse = true;
        string prompt;

        PromptGenerator William = new PromptGenerator();
        Entry Neffi = null;

        Journal Franz = new Journal();



        while (CorrectResponse)
        {
            Console.WriteLine("Welcome to the Jornal program!");
            Console.WriteLine("Please select one of the following choices");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do!");
            Response = int.Parse(Console.ReadLine());

            if (Response == 5) { CorrectResponse = false; }


            switch (Response)
            {
                case 1:// for Write
                    William.Write();
                    prompt = William.selectPrompt;

                    Console.WriteLine("Write your entry:");
                    string userText = Console.ReadLine();

                    string dateText = DateTime.Now.ToShortDateString();

                    Neffi = new Entry(dateText, prompt, userText);
                    Franz._entries.Add(Neffi);

                    break;

                case 2:// for Display

                    if (Neffi != null)
                    {
                        Neffi.Display();
                    }
                    else
                    {
                        Console.WriteLine("No entry yet.");
                    }

                    break;

                case 3:// for Load
                    Console.WriteLine("What is the file name?");
                    string loadFile = Console.ReadLine();
                    Franz.Load(loadFile);
                    Console.WriteLine("Journal loaded successfully!");
                    break;

                case 4:// for Save
                    Console.WriteLine("What is the file name?");
                    string fileName = Console.ReadLine();
                    Franz.Save(fileName);
                    break;

                case 5:// for Quit
                    Console.WriteLine("See you tomorrow!");
                    break;


                default:
                    Console.WriteLine("Chosse another number from 1 to 5!");
                    break;





            }

        }


    }


}