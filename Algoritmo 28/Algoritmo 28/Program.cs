using System;

namespace Algoritmo_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factores Primos");
            int numero, resultado, contador;
            Console.Write("Ingrese un numero: "); 
            string num = Console.ReadLine();
            numero = int.Parse(num);
            contador = 2;
            while ((numero != 1))
            {
                resultado = numero % contador;
                if ((resultado == 0))
                {
                    Console.WriteLine(contador);
                    numero /= contador;
                }
                else
                {
                    contador += 1;
                }
            }
        }
    }
}
