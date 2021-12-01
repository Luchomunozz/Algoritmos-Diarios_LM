using System;

namespace Algoritmo_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplo de 3");
            float Numero1;
            Console.WriteLine("Ingrese el primer número: ");
            Numero1 = Convert.ToInt32(Console.ReadLine());

            if(Numero1%3 == 0)
            {
                Console.WriteLine(Numero1 + "es múltiplo de 3");
            }
            else
            {
                Console.WriteLine(Numero1 + "no es múltiplo de 3");
            }
        }
    }
}
