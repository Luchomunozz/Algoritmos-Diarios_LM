using System;

namespace Algoritmo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sueldo Total");
            Console.WriteLine("Ingrese las horas laboradas");
            int Hlabor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la tarifa por hora");
            int Thora = Convert.ToInt32(Console.ReadLine());

            int Sueldo = (Hlabor * Thora);
            Console.WriteLine("Su sueldo es de: ");
            Console.WriteLine(Sueldo);
            Console.ReadLine();
        }
    }
}
