using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int userNumber = -1;
        int sum = 0;
        

        while (userNumber != 0)
        {
            Console.WriteLine("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

                if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            
        }
        foreach (int number in numbers)
            {
                sum = sum + number;
            }
        
        double average = (double)sum / numbers.Count;

        int mayor = numbers[0];
        foreach (int number in numbers)
        {
            if(number > mayor)
            {
                mayor = number;
            }
        }

        int nearTo = int.MaxValue;
        foreach (int number in numbers)
        {
            if(number > 0 && number < nearTo)
            {
                nearTo = number;
            }
            
        }


        Console.WriteLine($"The sume is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {mayor}");
        Console.WriteLine($"The smallest positive number is: {nearTo}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
} 