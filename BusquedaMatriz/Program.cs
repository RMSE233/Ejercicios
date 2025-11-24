using System;

namespace BusquedaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int filas = 10;
            int columnas = 10;
            int[,] matriz = new int[filas, columnas];

            // Llenar la matriz con números aleatorios entre 1 y 100
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = rand.Next(1, 101);
                }
            }

            // Mostrar la matriz
            Console.WriteLine("Matriz 10x10 generada:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j].ToString("D2") + " ");
                }
                Console.WriteLine();
            }

            // Solicitar número a buscar
            Console.Write("\nIngrese el número a buscar: ");
            if (!int.TryParse(Console.ReadLine(), out int objetivo))
            {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            // Búsqueda exhaustiva
            bool encontrado = false;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] == objetivo)
                    {
                        Console.WriteLine($"Número {objetivo} encontrado en la posición [{i},{j}]");
                        encontrado = true;
                    }
                }
            }

            if (!encontrado)
                Console.WriteLine($"Número {objetivo} no encontrado en la matriz.");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
