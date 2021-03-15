using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).
            
            String L=""; int  N = 0;
            Console.WriteLine("Digite una letra para ver el abecedario de forma descendente");
            L=Console.ReadLine();
            for ( N = 90; N >= 65; N--)
            {
                Console.WriteLine("Letra: "+ Convert.ToString((char)N));
            }
            Console.ReadKey();
        }
    }
}
