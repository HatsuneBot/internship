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

        private double Length
        {
            get
            {
                Point tmp = new Point(end.X - start.X, end.Y - start.Y, end.Z - start.Z);
                return Math.Sqrt(Math.Pow(tmp.X, 2) + Math.Pow(tmp.Y, 2)+ Math.Pow(tmp.Z, 2));
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
