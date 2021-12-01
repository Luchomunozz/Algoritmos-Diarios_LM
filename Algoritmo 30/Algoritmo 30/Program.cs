using System;

namespace Algoritmo_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Puntaje Menor");
            float puntaje1, puntaje2, puntaje3, puntaje4;
            Console.WriteLine("Ingrese el primer puntaje: ");
            puntaje1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo puntaje: ");
            puntaje2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer puntaje: ");
            puntaje3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto puntaje: ");
            puntaje4 = float.Parse(Console.ReadLine());
            float puntajeMenor = puntaje1;
            if (puntaje2 < puntajeMenor)
            {
                puntajeMenor = puntaje2;
            }
            else if (puntaje3 < puntajeMenor)
            {
                puntajeMenor = puntaje3;
            }
            else if (puntaje4 < puntajeMenor)
            {
                puntajeMenor = puntaje4;
            }
            float promedio = (puntaje1 + puntaje2 + puntaje3 + puntaje4 - puntajeMenor) / 3;
            Console.WriteLine("El puntaje menor es de"+puntajeMenor);
        }
    }
}
