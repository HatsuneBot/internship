using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(new Point (2,0,2),new Point(0,1,0));
            Vector v2 = new Vector(new Point (0,1,0),new Point(2,0,2));
            double sum = v1 + v2;
            double dif = v1 - v2;
            double mult = v1 * v2;

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.ReadKey();
        }
    }
}
