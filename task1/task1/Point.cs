using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Point
    {
        
        private double X {get;set;}
        private double Y{get;set;}

        public void GetData(List <Point> list,double a, double b)
        {
            list.Add(new Point() { X = a, Y = b });
        }

        public override string ToString()
        {
            return "X:"+ X + "\tY:" + Y;
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
