using System;

namespace Algoritmo_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de dos cifras invertidos");
            int numero, auxiliar, decenas, unidades;
            Console.WriteLine("Ingrese un número :");
            string num = Console.ReadLine();
            numero = int.Parse(num);
            decenas = numero / 10;
            unidades = numero % 10;
            auxiliar = (unidades * 10) + decenas;
            Console.WriteLine("El numero invertido queda así: " + auxiliar);
        }
    }
}
