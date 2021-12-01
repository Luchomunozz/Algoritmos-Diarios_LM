using System;

namespace Algoritmo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area del triángulo");
            Console.WriteLine("Ingrese la base");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            int Altura = Convert.ToInt32(Console.ReadLine());

            int area = (Base * Altura) / 2;
            Console.WriteLine("El area del triángulo es:");
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}
