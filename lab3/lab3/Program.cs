using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            // Введення кількості чисел
            Console.WriteLine("Введіть кількість чисел:");
            int n = int.Parse(Console.ReadLine());

            // Ініціалізація змінної для суми
            double sum = 0;

            // Введення чисел та обчислення суми
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Введіть число {i}:");
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }

            // Обчислення середнього арифметичного
            double average = sum / n;

            // Виведення результату
            Console.WriteLine($"Середнє арифметичне: {average}");

            //2
            Console.WriteLine("Введіть значення x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення y:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення z:");
            double z = double.Parse(Console.ReadLine());

            double[] A = new double[3]; // Ініціалізація масиву з першими трема елементами

            A[0] = A[1] = x; // Перші два елементи рівні x
            A[2] = y; // Третій елемент рівний y

            int count = 0; // Лічильник елементів, більших за z

            for (int i = 3; i < A.Length; i++)
            {
                A[i] = A[i - 2] + (A[i - 1] / Math.Pow(2, A[i - 1])) * A[i - 3];
                if (A[i] > z)
                {
                    count++;
                }
            }

            Console.WriteLine($"Кількість елементів масиву А, які більші за {z}: {count}");

            //3
            // Введення розмірності векторів
            Console.WriteLine("Введіть розмірність векторів:");
            int n = int.Parse(Console.ReadLine());

            // Ініціалізація масивів для векторів x та y
            double[] x = new double[n];
            double[] y = new double[n];

            // Введення координат вектора x
            Console.WriteLine("Введіть координати вектора x:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"x[{i + 1}]: ");
                x[i] = double.Parse(Console.ReadLine());
            }

            // Введення координат вектора y
            Console.WriteLine("Введіть координати вектора y:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"y[{i + 1}]: ");
                y[i] = double.Parse(Console.ReadLine());
            }

            // Обчислення скалярного добутку векторів x та y
            double dotProduct = 0;
            for (int i = 0; i < n; i++)
            {
                dotProduct += x[i] * y[i];
            }

            // Перевірка на перпендикулярність
            if (dotProduct == 0)
            {
                Console.WriteLine("Вектори x і y є перпендикулярними.");
            }
            else
            {
                Console.WriteLine("Вектори x і y не є перпендикулярними.");
            }

            //4

            // Оголошення та ініціалізація вихідного масиву
            int[] array = { 3, 0, 2, 0, 5, 1, 0, 4 };

            // Перестановка елементів у масиві
            int zeroIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    // Знаходимо перший ненульовий елемент
                    if (array[zeroIndex] != 0)
                    {
                        zeroIndex = i;
                    }
                }
                else
                {
                    // Міняємо місцями елементи
                    int temp = array[i];
                    array[i] = array[zeroIndex];
                    array[zeroIndex] = temp;
                    // Збільшуємо індекс нульового елемента
                    zeroIndex++;
                }
            }

            // Виведення результату
            Console.WriteLine("Перетворений масив:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
