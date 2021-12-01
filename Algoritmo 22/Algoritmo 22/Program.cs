using System;

namespace Algoritmo_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros Primos");
            int numero, contador, cont2, resultado;
            contador = 2;
            cont2 = 0;
            Console.Write("Ingrese un numero:");
            string num = Console.ReadLine();
            numero = int.Parse(num);
            while (contador < numero && cont2 == 0)
            {
                resultado = numero % contador;
                if (resultado == 0)
                {
                    cont2 = 1;
                }
                else
                {
                    contador += 1;
                }
            }
            if (cont2 == 0)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
        }
    }
}
