using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_WPF
{
    public class Point
    {
        private double x;
        private double y;

        
        public Point (double a, double b)
        {
            x = a;
            y = b;
        }

        public override string ToString()
        {
            return "X:" + x + "\tY:" + y + "\n";
        }

    }
}
