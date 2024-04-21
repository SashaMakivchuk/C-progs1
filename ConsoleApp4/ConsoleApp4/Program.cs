using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a = ");
                a[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
