﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorApp
{
    public class Vector
    {
        private Point startPoint { get; set; }
        private Point endPoint { get; set; }

        public Vector() { }

        public Vector(Point a, Point b)
        {
            startPoint = a;
            endPoint = b;
        }

        public double Length
        {
            get
            {
                Point dif = endPoint - startPoint;
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
            return string.Format("({0},{1})", startPoint,endPoint);
        }
    }
}
