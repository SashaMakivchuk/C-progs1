using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void InputMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Елемент [{i + 1},{j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    
    static void Main(string[] args)
        {
            //1
            // Оголошення та ініціалізація матриці
            int[,] matrix = {
            { 1, -2, 3 },
            { -4, 5, -6 },
            { 7, -8, 9 }
        };

            // Підрахунок кількості від'ємних елементів з обома непарними індексами
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i % 2 != 0 && j % 2 != 0 && matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            // Виведення результату
            Console.WriteLine($"Кількість від'ємних елементів матриці з обома непарними індексами: {count}");
            //2
            // Введення розмірності матриць
            Console.WriteLine("Введіть кількість рядків (m):");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кількість стовпців (n):");
            int n = int.Parse(Console.ReadLine());

            // Оголошення та ініціалізація матриць
            int[,] matrixA = new int[m, n];
            int[,] matrixB = new int[m, n];

            // Введення елементів матриць
            Console.WriteLine("Введіть елементи матриці A:");
            InputMatrix(matrixA);

            Console.WriteLine("Введіть елементи матриці B:");
            InputMatrix(matrixB);

            // Заміна нульових елементів матриці А відповідними елементами матриці В
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrixA[i, j] == 0)
                    {
                        matrixA[i, j] = matrixB[i, j];
                    }
                }
            }

            // Виведення результату
            Console.WriteLine("Матриця A після заміни нульових елементів:");
            PrintMatrix(matrixA);

            //3
            // Оголошення та ініціалізація матриці
            int[,] matrixA = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            // Оголошення та ініціалізація транспонованої матриці
            int[,] transposedMatrix = new int[matrixA.GetLength(1), matrixA.GetLength(0)];

            // Заповнення транспонованої матриці
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    transposedMatrix[j, i] = matrixA[i, j];
                }
            }

            // Виведення транспонованої матриці
            Console.WriteLine("Транспонована матриця:");
            PrintMatrix(transposedMatrix);

            //4

        }
    }
}
