using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Point
    {

        private double x;
        private double y;

        public void GetData(List <Point> list,double a, double b)
        {
            list.Add(new Point() { x = a, y = b });
        }

        public override string ToString()
        {
            return "X:"+ x + "\tY:" + y;
        }

        public void SetData(List<Point> list)
        {
            foreach(Point point in list)
            {
                Console.WriteLine(point);
            }
        }

    }
}
