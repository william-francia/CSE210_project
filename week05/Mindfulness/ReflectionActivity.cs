using System;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "-----Think of a time when you stood up for someone else.-----",
        "-----Think of a time when you did something really difficult.-----",
        "-----Think the time when you avercome with somthing difficult-----",
        "-----Think in What was the biggest challenge you faced-----"
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did it start?",
        "How did you feel afterwards?",
        "What did you learn from this experience?",
        "What made this moment stand out to you?",
        "What would you do differently if it happened again?"
    };


    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    { }

    public void Run()
    {
        DisplayStartMessage();
        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine(prompt);

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.\n");
        Console.WriteLine("You may begin in:");
        ShowCountdown(4);

        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < end)
        {
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            ShowSpinner(4);
        }

        DisplayEndMessage();
    }

}