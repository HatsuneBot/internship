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
            Console.WriteLine("Сумма векторов - {0}",sum);
            Console.WriteLine("Разность векторов - {0}",dif);
            Console.WriteLine("Произведение векторов - {0}", mult);
            Console.ReadKey();

            do
            {
                string[] separators = { ",", " ", "\n" };
                Console.WriteLine("Введите координаты первого вектора:");
                string s1 = Console.ReadLine();
                if(string.IsNullOrEmpty(s1) == true) break;
                Console.WriteLine("Введите координаты второго вектора:");
                string s2 = Console.ReadLine();
                if (string.IsNullOrEmpty(s2)==true) break;
                else {
                        string[] points1 = s1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        string[] points2 = s2.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        v1 = new Vector(new Point(int.Parse(points1[0]), int.Parse(points1[1]), int.Parse(points1[2])), new Point(int.Parse(points1[3]), int.Parse(points1[4]), int.Parse(points1[5])));
                        v2 = new Vector(new Point(int.Parse(points2[0]), int.Parse(points2[1]), int.Parse(points2[2])), new Point(int.Parse(points2[3]), int.Parse(points2[4]), int.Parse(points2[5])));

                        sum = v1 + v2;
                        dif = v1 - v2;
                        mult = v1 * v2;

                        Console.WriteLine(v1);
                        Console.WriteLine(v2);
                        Console.WriteLine("Сумма векторов - {0}", Math.Round(sum,5));
                        Console.WriteLine("Разность векторов - {0}", Math.Round(dif,5));
                        Console.WriteLine("Произведение векторов - {0}", Math.Round(mult,5));
                        Console.ReadKey();
                    }
            }
            while (true);
        }
    }
}
