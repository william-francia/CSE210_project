using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
        Console.WriteLine("Menu otions:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");

        Console.Write("Select a choice from the menu:");

        int response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                Console.Clear();
                new BreathingActivity().Run();
            }
            else if (response == 2)
            {
                Console.Clear();
                new ReflectionActivity().Run();
            }
            else if (response == 3)
            {
                Console.Clear();
                new ListingActivity().Run();
            }
            else if (response == 4)
            {
                running = false;
                Console.WriteLine("Thank you for your time, have a good one!");
            }
            else
            {
                Console.WriteLine("Plese introduce numbers from 1 to 4, thank you!");
            }
        }

    }
}