using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static int CalculateXn(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n >= 1 && n <= 3)
            {
                return 7;
            }

            int[] x = new int[n + 1];
            x[0] = 0;
            x[1] = x[2] = x[3] = 7;

            for (int i = 4; i <= n; i++)
            {
                x[i] = (x[i - 1] * (1 + x[i - 2]) + x[i - 3]) / x[i - 4];
            }

            return x[n];
        }
        // Підпрограма для перевірки чи є четвірка чисел геометричною прогресією
        static bool IsGeometricProgression(int a, int b, int c, int d)
        {
            return b * b == a * c && c * c == b * d;
        }

        // Підпрограма для знаходження кількості геометричних прогресій у послідовності
        static int CountGeometricProgressions(int[] sequence)
        {
            int count = 0;
            for (int i = 0; i < sequence.Length - 3; i++)
            {
                if (IsGeometricProgression(sequence[i], sequence[i + 1], sequence[i + 2], sequence[i + 3]))
                {
                    count++;
                }
            }
            return count;
        }
    
    static int NSD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            //1
            // Введення значень a та b
            Console.WriteLine("Введіть значення a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення b:");
            int b = int.Parse(Console.ReadLine());

            // Обчислення значення виразу S
            int S = NSD(a, b) + NSD(a, 4) + NSD(24, b);

            // Виведення результату
            Console.WriteLine($"Значення виразу S = {S}");
            //2
            // Введення послідовності
            Console.WriteLine("Введіть кількість чисел у послідовності:");
            int n = int.Parse(Console.ReadLine());

            int[] sequence = new int[n];

            Console.WriteLine("Введіть числа послідовності:");

            for (int i = 0; i < n; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }

            // Знаходження кількості геометричних прогресій
            int count = CountGeometricProgressions(sequence);

            // Виведення результату
            Console.WriteLine($"Кількість геометричних прогресій: {count}");

            //3
            // Введення номера шуканого члена послідовності
            Console.WriteLine("Введіть номер шуканого члена послідовності:");
            int n_1 = int.Parse(Console.ReadLine());

            // Обчислення значення x_n
            int xn = CalculateXn(n_1);

            // Виведення результату
            Console.WriteLine($"x_{n} = {xn}");
            Console.ReadLine();
        }
    }
}
