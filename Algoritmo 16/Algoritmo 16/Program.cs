using System;

namespace Algoritmo_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mayores, menores o iguales a 0");
            Console.WriteLine("Ingrese la cantidad de numeros a introducir");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int contador = 1;
            int contadorMenor = 0;
            int contadorMayor = 0;
            int contadorIgual = 0;
            for (contador = 1; contador <= cantidad; contador++)
            {
                Console.WriteLine("Ingrese un número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero > 0)
                {
                    contadorMayor += 1;
                    Console.WriteLine("Estos números son mayores a cero: " + "" + numero);
                }
                else if(numero < 0)
                {
                    contadorMenor += 1;
                    Console.WriteLine("Estos numeros son menores a cero: " + "" + numero);
                }
                else
                {
                    contadorIgual += 0;
                    Console.WriteLine("Estos numeros son iguales a cero: " + "" + numero);
                }
            }
        }
    }
}
