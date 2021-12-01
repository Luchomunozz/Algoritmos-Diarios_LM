using System;

namespace Algoritmo_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Respuestas correctas, incorrectas y en blanco");
            int correctas, incorrectas, en_blanco;
            Console.WriteLine("Ingrese las respuestas correctas: ");
            correctas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese las respuestas incorrectas: ");
            incorrectas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese las respuestas en blanco: ");
            en_blanco = Convert.ToInt32(Console.ReadLine());

            int puntajeFinal = (correctas * 4) - incorrectas;
            Console.WriteLine("Su puntaje final es:" + puntajeFinal + "y las respuestas en blanco son" + en_blanco);

        }
    }
}
