using System;

namespace Algoritmo_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Par o Impar");
            int Num1, Num2;
            Console.WriteLine("Ingrese el primer numero: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            if (Num1%2 == 0)
            {
                Console.WriteLine(Num1+"Es par");
            }
            else
            {
                Console.WriteLine(Num1+"Es impar");
            }
            if (Num2%2 == 0)
            {
                Console.WriteLine(Num2+"Es par");
            }
            else
            {
                Console.WriteLine(Num2 +"Es impar");
            }
        }
    }
}
