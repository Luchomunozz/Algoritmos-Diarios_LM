using System;

namespace Algoritmo_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de numeros de 10 en 10");
            int numero;
            Console.WriteLine("Ingrese un numro por favor: ");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= numero; i++)
            {
                for (int j = 0; j <= numero; j++)
                {
                    Console.WriteLine(j + "" + i + "");
                }
            }
        }
    }
}
