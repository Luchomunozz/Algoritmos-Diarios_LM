using System;

namespace Algoritmo_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tablas de multiplicar");
            byte numero;
            int resultado;
            Console.Write("Por favor digite un numero");
            string num = Console.ReadLine();
            numero = byte.Parse(num);
            for (int i = 1; i <= 12; i++)
            {
                resultado = numero * i;
                Console.WriteLine("{0} * {1} = {2}", numero, i, resultado);
            }
        }
    }
}
