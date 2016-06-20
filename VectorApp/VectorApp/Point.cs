using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorApp
{
    public class Point
    {
        private int X { get; set; }
        private int Y { get; set; }
        private int Z { get; set; }

        public Point (int a, int b, int c)
        {
            X = a;
            Y = b;
            Z = c;
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public double FindPow
        {
            get
            { return Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2); }
        }

        public override string ToString()
        {
            return string.Format("({0},{1},{2})", X,Y,Z);
        }
    }
}
