using System;

namespace Algoritmo_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descuentos");
            Console.WriteLine("Ingrese el valor de la compra");
            int ValorCompra = Convert.ToInt32(Console.ReadLine());

            if (ValorCompra > 1000)
            {
                double Descuento = ValorCompra * 0.2;
                Console.WriteLine("El valor con descuento es: " + Descuento);
            }
            else
            {
                Console.WriteLine("El valor sin descuento es: " + ValorCompra);
            }
        }
    }
}
