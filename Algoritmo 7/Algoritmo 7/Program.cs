using System;

namespace Algoritmo_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menor a mayor");
            int Num1, Num2;
            Console.WriteLine("Ingrese el primer número: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            if (Num1 > Num2)
            {
                Console.WriteLine((Num2, Num1));
            }
            else
            {
                Console.WriteLine((Num1, Num2));
            }
        }
    }
}
