using System;

namespace Algoritmo_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Igualdad de números");
            int Num1, Num2;
            Console.WriteLine("Ingrese el primer numero");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            Num2 = Convert.ToInt32(Console.ReadLine());
            if (Num1 == Num2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }
        }
    }
}
