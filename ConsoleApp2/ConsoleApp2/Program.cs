using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static double Sum(double x, double e)
        {
            double Sum = 0;
            int n = 1;
            double a = x / 1;
            while (a > e)
                Sum = Sum + a;
                a = Math.Pow(x, n+1)/(n+1);
                n++;
            return Sum;
            
        }
        static void Main(string[] args)
        {

            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("e = ");
            double e = double.Parse(Console.ReadLine());
            double S = Sum(x, e);
            Console.WriteLine($"Sum={S}");
            Console.ReadLine();
        }
    }
}
