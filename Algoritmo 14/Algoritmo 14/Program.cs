using System;

namespace Algoritmo_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero capicua de tres cifras");
            int Numero, unidades, centenas;
            Console.WriteLine("Ingrese un número: ");
            Numero = Convert.ToInt32(Console.ReadLine());
            if(Numero>99 && Numero < 1000)
            {
                unidades = (Numero%10);
                centenas = (Numero % 10);
                if(unidades == centenas)
                {
                    Console.WriteLine(Numero +""+ "Es capicua");
                }
                else
                {
                    Console.WriteLine(Numero +""+ "No es capicua");
                }
            }
            else
            {
                Console.WriteLine(Numero +""+ "No es un numero de tres cifras");
            }
        }
    }
}
