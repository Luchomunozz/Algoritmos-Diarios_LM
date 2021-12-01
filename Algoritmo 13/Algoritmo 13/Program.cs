using System;

namespace Algoritmo_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clasificación de los triángulos: ");
            float Lado1, Lado2, Lado3;
            Console.WriteLine("Ingrese la medida del primer lado: ");
            Lado1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Ingrese la medida del segundo lado: ");
            Lado2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Ingrese la medida del tercer lado: ");
            Lado3 = Convert.ToInt32(Console.ReadLine());
            if (Lado1 == Lado2 && Lado2==Lado3)
            {
                Console.WriteLine("El triángulo es equilátero");
            }
            else if (Lado1 == Lado2 && Lado2 != Lado3)
            {
                Console.WriteLine("El triángulo es isósceles");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno");
            }
        }
    }
}
