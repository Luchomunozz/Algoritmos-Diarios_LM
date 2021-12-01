using System;

namespace Algoritmo_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Secuencia en escalera");
            int numero;
            Console.WriteLine("Secuencia 1");
            Console.WriteLine("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("" + j);
                }
                Console.WriteLine("");
            }
        }
    }
}
