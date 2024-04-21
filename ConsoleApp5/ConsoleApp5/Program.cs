using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        //static double MaxEl(double[] c)
        //{
        //    double b = c[0];
        //    int d = 0;
        //    for (int i = 1; i < c.Length; i++)
        //    {
        //        if (c[i] > b)
        //        {
        //            b = c[i];
        //            d = i;
        //        }
        //        ;
        //    }
        //    Console.WriteLine($"Max index {d}");
        //    return b;
        //}
        static double MaxEl(double[,] c)
        {
            double b = c[0,0];
            int d = 0;
            int e = 0;
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    if (c[i,j] > b)
                    {
                        b = c[i,j];
                        d = i;
                        e = j;
                    }
                }
            }
            Console.WriteLine($"Max index [{d},{e}]");

            return b;
        }
        //static double AvarageEl(double[] c)
        //{
        //    double b = 0;
        //    for (int i = 0; i<c.Length; i++)
        //    {
        //        b = b + c[i];
        //    }
        //    b = b / c.Length;
        //    return b;
        //}
        static double AvarageEl(double[,] c)
        {
            double b = 0;
            for(int i = 0; i < c.GetLength(0); i++)
            {
                for(int j = 0; j < c.GetLength(1); j++)
                {
                    b = b + c[i,j];

                }
                
            }
            b = b / c.Length;
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("m = ");
            int m = int.Parse(Console.ReadLine());
            //double[] a = new double[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"a{i} = ");
            //    a[i] = double.Parse(Console.ReadLine());
            //}
            
            //Console.WriteLine(MaxEl(a));
            
            //Console.WriteLine(AvarageEl(a));
            //for (int i = 0;i < n; i++)
            //{
            //    Console.WriteLine("a[{0}]={1}", i, a[i]);
            //}
            double[,] f = new double[n, m];
            for (int i = 0;i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    Console.WriteLine($"f{i}{j} = ");
                    f[i, j] = double.Parse(Console.ReadLine());
                }
            }
           
            for (int i = 0; i<n ; i++)
            {
                for(int j = 0;j < m; j++)
                {
                    Console.WriteLine($"f{i}{j} = {f[i,j]}");
                }
            }
            Console.WriteLine(MaxEl(f));
            Console.WriteLine(AvarageEl(f));
            Console.ReadLine();
            
        }
    }
}
