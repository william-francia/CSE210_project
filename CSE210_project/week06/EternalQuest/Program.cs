using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;

        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goals);
                    break;
                case "2":
                    ListGoals(goals);
                    break;
                case "3":
                    SaveGoals(goals, totalPoints);
                    break;
                case "4":
                    LoadGoals(goals, ref totalPoints);
                    break;
                case "5":
                    RecordEvent(goals, ref totalPoints);
                    break;
                case "6":
                    Console.WriteLine("Good bye");
                    break;
                default:
                    System.Console.WriteLine("Invalid option, please select from 1 to 6, just numbers are allowed");
                    break;
            }
        }





    }

    static void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("The type of goal are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("How many times must this goal be accomplished? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid option.");
                return;
        }

        goals.Add(newGoal);

        Console.WriteLine("Goal created successfully!");
    }

    static void ListGoals(List<Goal> goals)
    {
        Console.WriteLine("Your current goals:");

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        int index = 1;

        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }
    
    static void RecordEvent(List<Goal> goals, ref int totalPoints)
{
    if (goals.Count == 0)
    {
        Console.WriteLine("No goals available to record.");
        return;
    }

    Console.WriteLine("The goals are:\n");

    int index = 1;
    foreach (Goal goal in goals)
    {
        Console.WriteLine($"{index}. {goal.GetDetailsString()}");
        index++;
    }

    Console.Write("\nWhich goal did you accomplish? ");
    int choice = int.Parse(Console.ReadLine());
    choice--;

    if (choice < 0 || choice >= goals.Count)
    {
        Console.WriteLine("Invalid goal selection.");
        return;
    }

    Goal selectedGoal = goals[choice];

    // Registrar evento
    selectedGoal.RecordEvent();

    // Sumar puntos base
    totalPoints += selectedGoal.Points;

    Console.WriteLine($"\nCongratulations you have earned {selectedGoal.Points} points!");

    // Si es checklist y lo completó → sumar bonus
    if (selectedGoal is ChecklistGoal checklist)
    {
        if (checklist.IsComplete())
        {
            Console.WriteLine("Bonus achieved!");
            totalPoints += checklist.BonusPoints;
        }
    }

    Console.WriteLine($"You now have {totalPoints} points!");
    Console.WriteLine($"You have {totalPoints} points.");
}



    static void SaveGoals(List<Goal> goals, int totalPoints)
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalPoints);

            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }
    static void LoadGoals(List<Goal> goals, ref int totalPoints)
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        goals.Clear(); 

        totalPoints = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            string[] parts = line.Split(": ");
            string type = parts[0];

            string[] data = parts[1].Split("|");

            if (type == "SimpleGoal")
            {
                goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "EternalGoal")
            {
                goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "ChecklistGoal")
            {
                goals.Add(new ChecklistGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    int.Parse(data[3]),
                    int.Parse(data[4])
                ));
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }


}