using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorApp
{
    class Vector
    {
        private Point start { get; set; }
        private Point end { get; set; }

        public Vector(Point a, Point b)
        {
            start = a;
            end = b;
        }

        public double Length
        {
            get
            {
                Point dif = end - start;
                return Math.Sqrt(dif.FindPow);
            }
        }
        public static double operator +(Vector a, Vector b)
        {
            return a.Length + b.Length;
        }
        public static double operator -(Vector a, Vector b)
        {
            return a.Length-b.Length;
        }
        public static double operator *(Vector a, Vector b)
        {
            return a.Length*b.Length;
        }
        public override string ToString()
        {
            return string.Format("({0},{1})", start,end);
        }
    }
}
