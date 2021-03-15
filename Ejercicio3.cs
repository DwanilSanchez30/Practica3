using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que muestre los primeros 10 números pares a partir del producto de (10 x 10).
            for (int N1 = 100; N1 <= 120; N1=N1+2)
            {
                Console.WriteLine("Los 10 primeros numeros pares despues de multiplicar 10 por 10");
                Console.WriteLine(N1);
            }
            Console.Read(); 
        }
    }
}