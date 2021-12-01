using System;

namespace Algoritmo_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Secuencia 2");
            int contador = 1;
            Console.WriteLine("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            string textoSuma = "S = ";
            int Positivo = 0;
            int esNegativo = 1;
            int suma = 0;
            while (contador <= numero)
            {
                Console.WriteLine(contador);
                if (Positivo < esNegativo)
                {
                    textoSuma = textoSuma + " + " + contador;
                    Positivo += 1;
                    suma += contador;
                }
                else
                {
                    textoSuma = textoSuma + " - " + contador;
                    Positivo = 0;
                    suma -= contador;
                    esNegativo += 1;
                    suma -= contador;
                }
                contador += 1;
            }
            Console.WriteLine(textoSuma);

        }
    }
}
