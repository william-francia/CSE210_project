using System;

class ListingActivity : Activity
{
    private List<string> _ListListing = new List<string>
    {
        "When have you felt the holy Gost in this month?",
        "How do you feel when you go to the Church?",
        "What are you doing so you are able to receive the holy Gost?"
    };
    public ListingActivity () : base ("listing Activity", "This activity will help you reflect on the good things in your life by having you list as many thing s as you can in a certain area.")
    {}
    public void Run()
    {
        DisplayStartMessage();
        Random random = new Random();
        Console.WriteLine(_ListListing[random.Next(_ListListing.Count)]);

        Console.WriteLine("Starting in...");
        ShowCountdown(3);

        List<string> answers = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            answers.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {answers.Count} items!");

        DisplayEndMessage();

    }


}