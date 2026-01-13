using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);
        
        string gess;
        int gesser;


        do
        {
            Console.WriteLine("What is your guess? ");
            gess = Console.ReadLine();
            gesser = int.Parse(gess);
            if (gesser > magic)
            {
                Console.WriteLine("lower");
            }
            else if (gesser < magic)
            {
                Console.WriteLine("higher");
            }
            else
            {
                Console.WriteLine("You gessed it!");
            }
        } while (gesser != magic);


    }
}