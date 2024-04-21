using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static double DistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    
        static void Main(string[] args)
        {
            //1
            double a, b, angleDegrees;

            Console.WriteLine("Введіть довжину першої сторони (a): ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть довжину другої сторони (b): ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть величину кута між сторонами в градусах: ");
            angleDegrees = Convert.ToDouble(Console.ReadLine());

            double angleRadians = angleDegrees * Math.PI / 180;

            double area = 0.5 * a * b * Math.Sin(angleRadians);

            Console.WriteLine("Площа трикутника: " + area);

            //2
            double x, y;

            Console.WriteLine("Введіть координату x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть координату y: ");
            y = Convert.ToDouble(Console.ReadLine());

            int quadrant;

            if (x > 0 && y > 0)
            {
                quadrant = 1;
            }
            else if (x < 0 && y > 0)
            {
                quadrant = 2;
            }
            else if (x < 0 && y < 0)
            {
                quadrant = 3;
            }
            else if (x > 0 && y < 0)
            {
                quadrant = 4;
            }
            else
            {
                Console.WriteLine("Точка знаходиться на вісі або її координати неправильні.");
                return;
            }

            Console.WriteLine("Точка знаходиться в координатній чверті номер " + quadrant);

            //3
            double x1, y1, x2, y2, x3, y3;

            Console.WriteLine("Введіть координати першої вершини (x1, y1): ");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть координати другої вершини (x2, y2): ");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть координати третьої вершини (x3, y3): ");
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());

            double side1 = DistanceBetweenPoints(x1, y1, x2, y2);
            double side2 = DistanceBetweenPoints(x2, y2, x3, y3);
            double side3 = DistanceBetweenPoints(x3, y3, x1, y1);

            double maxSide = Math.Max(side1, Math.Max(side2, side3));

            Console.WriteLine("Найбільша сторона трикутника має довжину: " + maxSide);

            //4
            Console.WriteLine("Введіть значення x: ");
            double x_1 = Convert.ToDouble(Console.ReadLine());

            double expressionValue = 2 * x_1 * x_1 - x_1 - 3;

            if (expressionValue == 0)
            {
                Console.WriteLine("y = 1");
            }
            else if (expressionValue > 0)
            {
                Console.WriteLine("y = 2");
            }
            else
            {
                Console.WriteLine("y = 0");
            }
            Console.ReadLine();

        }
    }
}
