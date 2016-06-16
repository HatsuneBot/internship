using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Polynom p1 = new Polynom(1, 2);
            Polynom p2 = new Polynom(10, 20, 30, 40);
            Console.WriteLine(p1 + p2);
            Console.WriteLine(p1 - p2);
            Console.WriteLine(p1 * p2);
            Console.WriteLine(p1 == p2);
            Console.WriteLine((p1 * p2).Calculate(1.2d));
            Console.ReadKey();
        }
    }
}
