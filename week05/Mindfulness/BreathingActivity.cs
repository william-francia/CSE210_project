using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base ("Breathing Activity", "This activity will help you relax  by walking your through breathing in and out slowly. Clear your mi nd and focus on your breathing.") {

    }

public void Run()
    {
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("...");
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine("Now breathe out...");
            ShowCountdown(4);
        }

        DisplayEndMessage();
    }

}