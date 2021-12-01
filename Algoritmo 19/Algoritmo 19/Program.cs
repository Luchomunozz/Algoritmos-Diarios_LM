using System;

namespace Algoritmo_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de Numeros impares");
            int numero, suma;
            Console.WriteLine("Por favor ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            suma = 0;
            for (int contador = 1; contador <= numero; contador++)
            {
                Console.WriteLine(contador);
                suma += contador;
                contador += 1;
            }
            Console.WriteLine("El resultado de la suma de numeros impares es" + " " + suma);
        }
    }
}
