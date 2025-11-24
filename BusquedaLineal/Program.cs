using System;

namespace BusquedaLineal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arreglo = new int[20];

            // Generar arreglo con números aleatorios
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rnd.Next(1, 101); // Números aleatorios entre 1 y 100
            }

            Console.WriteLine("Arreglo generado:");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }

            // Solicitar número al usuario
            Console.WriteLine("\n\nIngrese un número a buscar:");
            int numero = int.Parse(Console.ReadLine());

            // Búsqueda lineal
            bool encontrado = false;
            int posicion = -1;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == numero)
                {
                    encontrado = true;
                    posicion = i;
                    break; // Se detiene al encontrarlo
                }
            }

            // Mostrar resultado
            if (encontrado)
            {
                Console.WriteLine($"\nEl número {numero} se encontró en la posición {posicion}.");
            }
            else
            {
                Console.WriteLine($"\nEl número {numero} NO existe en el arreglo.");
            }
        }
    }
}