using System;
using System.Collections.Generic;

namespace MaximoMinimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aleatorio = new Random();
            List<int> lista = new List<int>();

            for (int i = 0; i < 15; i++)
            {
                lista.Add(aleatorio.Next(1, 100));
            }

            Console.WriteLine("Lista de números:");
            foreach (var n in lista) Console.Write(n + " ");

            int maximo = lista[0];
            int minimo = lista[0];
            int iteraciones = 0;

            foreach (var n in lista)
            {
                iteraciones++;

                if (n > maximo) maximo = n;
                if (n < minimo) minimo = n;
            }

            Console.WriteLine($"\nMáximo: {maximo}");
            Console.WriteLine($"Mínimo: {minimo}");
            Console.WriteLine($"Iteraciones: {iteraciones}");
        }
    }
}
