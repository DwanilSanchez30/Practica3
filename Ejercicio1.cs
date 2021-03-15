using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos. 
            // (terminará cuando se teclea un número negativo o cero).
            
            int N=0, Suma=0;
            while (true)
            {
                Console.WriteLine("Digite un numero mayor a Cero: ");
                N = int.Parse(Console.ReadLine());
                if (N <= 0)
                {
                    Console.WriteLine("Se intodujo un numero que no es positivo, se detuvo el conteo");
                    break;
                }
                Suma=Suma+N;
                Console.WriteLine("La suma de los numeros introducidos es: {0}", Suma);
            }
            
        }
    }
}
