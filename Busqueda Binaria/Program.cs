using System;
using System.Collections.Generic;

namespace BusquedaBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // Generar lista de 30 números aleatorios entre 1 y 100
            List<int> numeros = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                numeros.Add(rand.Next(1, 101));
            }

            Console.WriteLine("Lista original:");
            Console.WriteLine(string.Join(", ", numeros));

            // Ordenar la lista
            numeros.Sort();
            Console.WriteLine("\nLista ordenada:");
            Console.WriteLine(string.Join(", ", numeros));

            // Pedir número a buscar
            Console.Write("\nIngrese el número a buscar: ");
            if (!int.TryParse(Console.ReadLine(), out int objetivo))
            {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            // Búsqueda binaria manual
            int izquierda = 0;
            int derecha = numeros.Count - 1;
            bool encontrado = false;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;

                Console.WriteLine($"\nMitad actual: índice {medio}, valor {numeros[medio]}");
                Console.WriteLine("Sub-lista actual: " + string.Join(", ", numeros.GetRange(izquierda, derecha - izquierda + 1)));

                if (numeros[medio] == objetivo)
                {
                    Console.WriteLine($"\nNúmero {objetivo} encontrado en el índice {medio}.");
                    encontrado = true;
                    break;
                }
                else if (numeros[medio] < objetivo)
                {
                    izquierda = medio + 1;
                    Console.WriteLine("Buscando en la mitad derecha...");
                }
                else
                {
                    derecha = medio - 1;
                    Console.WriteLine("Buscando en la mitad izquierda...");
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"\nNúmero {objetivo} no encontrado en la lista.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}