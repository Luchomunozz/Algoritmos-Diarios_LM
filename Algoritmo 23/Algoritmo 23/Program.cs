using System;

namespace Algoritmo_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Secuencia");
            int contador = 1;
            Console.WriteLine("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            string textoSuma = "S = ";
            int esPositivo = 1;
            int suma = 0;
            while (contador <= numero)
            {
                Console.WriteLine(contador);
                if (esPositivo == 1)
                {
                    textoSuma = textoSuma + " + " + contador;
                    suma += contador;
                    esPositivo = 0;
                }
                else
                {
                    textoSuma = textoSuma + " - " + contador;
                    suma -= contador;
                    esPositivo = 1;
                }
                contador += 1;
            }
            Console.WriteLine(textoSuma);
        }
    }
}
