using System;
using System.Configuration.Assemblies;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Plese select form 1 to 3, the number 3 is quit");
        // int respuesta_del_cliente = int.Parse(Console.ReadLine());
        // opciones(respuesta_del_cliente);

        Console.WriteLine("the program choose one number from 1 to 10 and you have to gess");

        TheGame();


    }




    

    static void TheGame()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 11);

            Console.WriteLine("You have to select one number");
            int numberYouGuess = int.Parse(Console.ReadLine());

            while (numberYouGuess != numeroSecreto)
            {

                switch (numberYouGuess.CompareTo(numeroSecreto))
                {
                    case -1:   // número menor
                        Console.WriteLine("Demasiado bajo");
                        break;

                    case 1:    // número mayor
                        Console.WriteLine("Demasiado alto");
                        break;
                }
                Console.WriteLine("You have to select one number");
                numberYouGuess = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("You guess it!!!");
        }
































        // static void opciones (int respuesta_del_cliente)
        // {
        //     string date = DateTime.Now.ToString();

        //     switch (respuesta_del_cliente)
        //     {
        //         case 1:
        //             Console.WriteLine("Hola como estas, espero te encuentres bien");
        //             break;
        //         case 2:
        //             Console.WriteLine($"This is the date of today{date}");
        //             break;
        //         default:
        //             Console.WriteLine("thank you for visiting us!!!");
        //             break;
        //     }

        // }




        // static void saludar()
        // {
        //     Console.WriteLine("HOla ocmo estas brow");
        // }

        // static void resta(int numero1, int numero2)
        // {
        //     int resultado = numero1 - numero2;
        //     Console.WriteLine($"this is the real life {resultado}");
        // }



        // static int Vocals(string text)
        // {
        //     int contador = 0;
        //     text = text.ToLower();

        //     foreach (char vocal in text)
        //     {
        //         if (vocal == 'a' || vocal == 'e' || vocal == 'i' || vocal == 'o' || vocal == 'u')
        //         {
        //             contador++;
        //         }
        //     }
        //     return contador;
        // }







    }