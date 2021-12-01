using System;

namespace Algoritmo_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de numeros pares");
            int Numero,contador,suma,adicional;
            Console.WriteLine("Por favor ingrese el limite de numeros: ");
            Numero = Convert.ToInt32(Console.ReadLine());
            adicional = 1;
            suma = 0;
            for (contador = 1; contador <= Numero; contador++)
            {
                if (adicional % 2 == 0)
                {
                    Console.WriteLine(adicional);
                    suma += adicional;
                }
                adicional++;
            }
            Console.WriteLine("El resultado de los números pares es" + "" + suma);

        }
    }
}
