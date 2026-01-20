using System;
using System.Data;

public class Program
{
    static void Main(string[] args)
    {
        int Response = 0;

        while (Response == 5)
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



            switch (Response)
            {
                case 1:// for Write
                    break;

                case 2:// for Display
                    break;

                case 3:// for Load
                    break;

                case 4:// for Save
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