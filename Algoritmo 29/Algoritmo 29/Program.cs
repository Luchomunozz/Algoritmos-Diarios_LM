using System;

namespace Algoritmo_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros pares o divisibles entre 3");
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadLine();
        }
    }
}
