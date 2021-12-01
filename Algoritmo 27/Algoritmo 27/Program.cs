using System;

namespace Algoritmo_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("area del circulo");
            float radio;
            Console.WriteLine("Ingrese el radio del circulo: ");
            radio = Convert.ToInt32(Console.ReadLine());
            double Pi = 3.1416;
            double area = (radio*radio) * Pi;
            Console.WriteLine("El area del circulo es: " + area);
        }
    }
}
