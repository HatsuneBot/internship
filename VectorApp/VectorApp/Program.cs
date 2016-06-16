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
            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(4, 5, 6);
            Vector v3 = v1 + v2;
            Vector v4 = v1 - v2;
            double m = v2 * v3;
            double c = Vector.Cos(v1, v2);

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);
            Console.WriteLine(m);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
