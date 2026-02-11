using System;
using System.Configuration.Assemblies;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Plese select form 1 to 3, the number 3 is quit");
        // int respuesta_del_cliente = int.Parse(Console.ReadLine());
        // opciones(respuesta_del_cliente);
        // Console.WriteLine("Ingrese el precio del producto?");
        // int ProductPrice = int.Parse(Console.ReadLine());


        // Console.WriteLine("Ingrese la categoría del cliente:");
        // Console.WriteLine("1 = Estudiante");
        // Console.WriteLine("2 = Adulto");
        // Console.WriteLine("3 = Adulto Mayor");
        // int Categori = int.Parse(Console.ReadLine());

        // double total = Alltotal(ProductPrice, Categori);

        // Alltotal(ProductPrice, Categori);
        // Console.WriteLine($"Este es el descuento {total}");


        // Console.WriteLine("ingrese el numbero de usuario.");
        // int Number = int.Parse(Console.ReadLine());

        // if (Number > 0)
        // {
        //     Console.WriteLine("Es positivo");
        // }
        // if (Number == 0)
        // {
        //     Console.WriteLine("El número es cero");
        // }

        // if (Number < 0)
        // {
        //     Console.WriteLine("El número es negativo");
        // }



        StudentMelisa Melisa = new StudentMelisa("Belen", 26, 99); 
        Console.WriteLine(Melisa.GetInfo());
        Console.WriteLine(Melisa.GetData());

        Universitario William = new Universitario ("William", 22, "Bacheilor");
        Console.WriteLine(William.GetInfo());
        Console.WriteLine(William.GetGrade());



    }

    class People
    {
        private string _Name;
        private int _age;
    
        public People (string name, int age)
        {
            _Name = name;
            _age = age;
        }
        public string GetInfo()
        {
            return _Name + " " + _age;
        }
    }   
    class StudentMelisa : People
    {
        private int _Notas;
        public StudentMelisa (string name, int age, int notas) : base(name, age)
        {
            _Notas = notas;
        }
        public string GetData()
        {
            return GetInfo() + " " + _Notas;
        }
    }
    class Universitario : People
    {
        private string _Grade;
        public Universitario (string name, int age, string grade) : base (name, age)
        {
            _Grade = grade;
        }
        public string GetGrade()
        {
            return GetInfo() + " " + GetGrade();
        }
    }





































//     static double Alltotal(int ProductPrice, int Categori)
//     {
//         if (Categori == 3)
//         {
//             return ProductPrice - ProductPrice * 0.20;
//         }
//         else if (Categori == 1)
//         {
//             return ProductPrice - ProductPrice * 0.10;
//         }
//         else if (Categori == 2)
//         {
//             Console.WriteLine("no tienes ningun desucuento.");
//             return ProductPrice;
//         }
//         else
//         {
//             Console.WriteLine("La categoria no es valida");
//             return ProductPrice;
//         }

//     }


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







