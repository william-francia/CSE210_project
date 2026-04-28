using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        string guess;
        int guesser;

        do
        {
            Console.WriteLine("What is your guess? ");
            guess = Console.ReadLine();
            guesser = int.Parse(guess);
            if (guesser > magic)
            {
                Console.WriteLine("lower");
            }
            else if (guesser < magic)
            {
                Console.WriteLine("higher");
            }
            else
            {
                Console.WriteLine("You gessed it!");
            }
        } while (guesser != magic);



    }
}