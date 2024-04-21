using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class TSMatrix
    {
        public double elements { get; set; }
        private int m;
        private int n;
        public int M
        {
            get
            {
                return m;
            }
            set
            {
                if (value < 0) throw new Exception("error");
            }
        }

        public int N
        {
            get
            {
                return n;
            }
            set
            {
                if (value < 0) throw new Exception("error");
            }
        }
        public TSMatrix(double elements,int n, int m)
        {
            double Elements = elements;
            M = m;
            N = n;

        }
        public TSMatrix() { }
        public TSMatrix(double elements, int m, int n, int m, int n) : this(elements, m, n)
        {
            M = m;
            N = n;
        }

    }
}
