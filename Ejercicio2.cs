using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".
            
            int N=0;
            do
            {
                N=N+1;
                Console.Write("{0} - ", N);
                Console.ReadKey();
            } while (N<10);
            
        }
    }
}
