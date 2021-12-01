using System;

namespace Algoritmo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promedio de notas");
            Console.WriteLine("Ingrese la primera nota: ");
            double Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota: ");
            double Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota: ");
            double Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cuarta nota: ");
            double Nota4 = double.Parse(Console.ReadLine());

            double promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            
            if (promedio >= 3.5)
            {
                Console.WriteLine("Aprobó");
                Console.WriteLine(promedio);
            }
            else
            {
                Console.WriteLine("No aprobó");
                Console.WriteLine(promedio);
            }

        }
    }
}
