using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorApp
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point (int a, int b, int c)
        {
            X = a;
            Y = b;
            Z = c;
        }
        public override string ToString()
        {
            return string.Format("({0},{1},{2})", X,Y,Z);
        }
    }
}
