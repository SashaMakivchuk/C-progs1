using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static double Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        static double AverageDigit(int number)
        {
            int sum = 0;
            int count = 0;

            while (number > 0)
            {
                sum += number % 10; 
                count++; 
                number /= 10; 
            }

            return (double)sum / count;
        }
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Введіть дійсне число a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть натуральне число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = 1;

            for (int i = 0; i < n; i++)
            {
                result *= (a + i);
            }

            Console.WriteLine("Добуток послідовності чисел: " + result);

            //2

            Console.WriteLine("Введіть число x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть число y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            double averageX = AverageDigit(x);
            double averageY = AverageDigit(y);

            if (averageX > averageY)
            {
                Console.WriteLine("Середнє арифметичне цифр у числа x більше.");
            }
            else if (averageY > averageX)
            {
                Console.WriteLine("Середнє арифметичне цифр у числа y більше.");
            }
            else
            {
                Console.WriteLine("Середнє арифметичне цифр у числа x та y рівне.");
            }


            //3

            double x = Math.PI / 4; // значення x (наприклад, π/4)
            double epsilon = 0.0001; // точність (наприклад, 0.0001)

            double sum = 0;
            int n = 10; // кількість членів послідовності для обчислення суми

            for (int i = 0; i < n; i++)
            {
                double term = Math.Pow(x, 2 * i + 1) / Factorial(2 * i + 1);
                if (i % 2 == 0)
                    sum += term;
                else
                    sum -= term;
            }

            if (Math.Abs(sum - Math.Sin(x)) < epsilon)
            {
                Console.WriteLine($"Рівність sin(x) = x - x^3/3! + x^5/5! + ... справедлива для x = {x} з точністю {epsilon}");
            }
            else
            {
                Console.WriteLine($"Рівність sin(x) = x - x^3/3! + x^5/5! + ... не справедлива для x = {x} з точністю {epsilon}");
            }

            //4
            int x0 = 1; // Початкове значення x0
            int n_2 = 10; // Кількість елементів у послідовності

            int xn = x0; // Змінна для збереження значення xi

            for (int i = 1; i <= n_2; i++)
            {
                xn += 2; // xi = xi-1 + 2
            }

            Console.WriteLine($"x10 = {xn}");
            Console.ReadLine();

        }
    }
}
