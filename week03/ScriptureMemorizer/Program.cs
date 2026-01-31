using System;
using System.Net.Quic;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("Jhon", 3, 16);

        string verseText = "For God so loved the world that he gave his only begotten Son";
        Scripture scripture = new Scripture(reference, verseText);

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type quit");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Program finished.");
                break;
            }
            
        }

    }
}