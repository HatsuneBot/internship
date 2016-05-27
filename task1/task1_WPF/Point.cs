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

        public void GetData(List<Point> list, double a, double b)
        {
            list.Add(new Point() { x = a, y = b });
        }

        public override string ToString()
        {
            return "X:" + x + "\tY:" + y + "\n";
        }

    }
}
