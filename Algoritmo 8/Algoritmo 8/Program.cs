using System;

namespace Algoritmo_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mayor de edad");
            int edad;
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }
        }
    }
}
