using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static double maxNum(double a, double b, double c, double d)
        {
            double f = a;
            if (f < b)
            {
                f = b;
            }
            else if (f < c)
            {
                f = c;
            }
            else
                f = d;
            return f;
            
        }

        static void fun(ref double a, ref double b)
        {
            if (a > b)
            {
                a = a * 10;
                b = b / 10;
            }
            else if (a < b)
            {

                a = a / 10;
                b = b * 10;

            }
            else
                Console.WriteLine("a=b");
                
        }

        static void funTwo(double a, double b, double c, double d, out double max)
        {
            max = a;
            if (max < b)
            {
                max = b;
            }
            else if (max < c)
            {
                max = c;
            }
            else
                max = d;
        }


        static  double funThree(params double[] numbers)
        {
            double max = numbers[0];
            for (int i = 1;  i < numbers.Length; i++) 
            {
               max = numbers[i];
            }

            return max;
        }

        static double funFour(double a, double b)
        {
            if (a = b)
            {
                return a;
            }
            else if (a > b)
            {
                a = a / b;
                if 
            }
        }
        static void Main(string[] args)
        {
            double a = 2;
            double b= 5;
            double c = 3;
            double d = 4;
            double s;

            funTwo(a, b, c, d, out s);
            //fun(ref c, ref d);
            //Console.WriteLine(c);
            Console.WriteLine(funThree(12, 213, 45, 345, 23, 12, 6, 4, 35, 666));
            Console.ReadLine();
        }
    }
}
