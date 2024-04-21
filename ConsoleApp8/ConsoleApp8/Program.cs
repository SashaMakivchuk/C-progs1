using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vectors vector_1 = new vectors(8,4);
            vectors vector_2 = new vectors(8,4);
            vectors vector_3 = new vectors(9,5);
            vectors vector_4 = new vectors(10, 0);
            vectors sum = vector_1 + vector_2;
            vectors sub = vector_1 - vector_2;
            vectors multi = vector_1 * vector_2;
            bool equal = vector_1 == vector_2;
            bool unequal = vector_3 != vector_4;
            bool more = vector_1 > vector_3;
            bool less = vector_3 < vector_4;
            Console.WriteLine($"sum{sum}");
            Console.WriteLine($"sub{sub}");
            Console.WriteLine($"multi{multi}");
            Console.WriteLine(equal);
            Console.WriteLine(unequal);
            Console.WriteLine(more);
            Console.WriteLine(less);

            Console.ReadLine();
        }
    }
}
