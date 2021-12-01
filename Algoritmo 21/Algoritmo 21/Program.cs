using System;

namespace Algoritmo_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial de un numero");
            byte Numero;
            long resultado = 1;
            Console.Write("Por favor digite un numero: ");
            string num = Console.ReadLine();
            Numero = byte.Parse(num);
            for (int i = 2; i <= Numero; i++)
            {
                resultado *= i;
                Console.WriteLine("El factorial del numero es: " + resultado);
            }
        }
    }
}
