using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Point
    {
        public List<Point> point_list = new List<Point>();
        private double X;
        private double Y;

        public void GetData(double a, double b)
        {
            X = a;
            Y = b;
            point_list.Add(this);
        }

        public override string ToString()        {
            return string.Format("X:"+ this.X+ "\tY:"+this.Y);
        }
        public void SetData()
        {
            foreach(Point point in point_list)
            {
                Console.WriteLine(point_list.ToString());
            }
        }
    }
}
