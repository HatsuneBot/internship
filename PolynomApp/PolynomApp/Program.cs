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
            Console.WriteLine("Сумма полиномов:{0} ",p1 + p2);
            Console.WriteLine("Разность полиномов:{0} ", p1 - p2);
            Console.WriteLine("Произведение полиномов:{0} ", p1 * p2);
            Console.WriteLine("Равенство полиномов:{0} ",p1 == p2);
            Console.WriteLine((p1 * p2).Calculate(1.2));
            Console.ReadKey();
        }
    }
}
