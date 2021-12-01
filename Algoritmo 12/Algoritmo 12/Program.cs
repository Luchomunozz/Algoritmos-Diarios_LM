using System;

namespace Algoritmo_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número mayor entre 3 numeros: ");
            int numero1, numero2, numero3;
            Console.WriteLine("Ingrese el primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            numero3 = Convert.ToInt32(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine(numero1 + "Es mayor");
            }
            else if (numero2>numero3)
            {
                Console.WriteLine(numero2 + "Es mayor");
            }
            else
            {
                Console.WriteLine(numero3 + "Es mayor");
            }
        }
    }
}
