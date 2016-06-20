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
            Console.ReadLine();

            
            do
            {
                string[] separators = { ",", " ", "\n" };
                bool flag = true, flag1;
                int tmp;
                string[] points1, points2;
                while (flag)
                {
                    flag1 = true;
                    Console.WriteLine("Введите координаты первого вектора:");
                    string s = Console.ReadLine();
                    if (string.IsNullOrEmpty(s) == true) { flag = false; break; }
                    points1 = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    if (points1.Length != 6) { Console.WriteLine("Неверно введены координаты! Введите 6 значений!");continue; }
                    for (int i=0;i<points1.Length;i++)
                    {
                        if (int.TryParse(points1[i], out tmp) == false) { Console.WriteLine("Неверно введены координаты! Введите целые числа!"); flag1=false; break; }
                    }
                    if (flag1 == false) continue;
                    v1 = new Vector(new Point(int.Parse(points1[0]), int.Parse(points1[1]), int.Parse(points1[2])), new Point(int.Parse(points1[3]), int.Parse(points1[4]), int.Parse(points1[5])));
                    break;
                }
                if (flag == false) break;

                while (flag)
                {
                    flag1 = true;
                    Console.WriteLine("Введите координаты второго вектора:");
                    string s = Console.ReadLine();
                    if (string.IsNullOrEmpty(s) == true) flag = false;
                    points2 = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    if (points2.Length != 6) { Console.WriteLine("Неверно введены координаты! Введите 6 значений!"); continue; }
                    for (int i = 0; i < points2.Length; i++)
                    {
                        if (int.TryParse(points2[i], out tmp) == false) { Console.WriteLine("Неверно введены координаты! Введите целые числа!"); flag1=false;break; }
                    }
                    if (flag1 == false) continue;
                    v2 = new Vector(new Point(int.Parse(points2[0]), int.Parse(points2[1]), int.Parse(points2[2])), new Point(int.Parse(points2[3]), int.Parse(points2[4]), int.Parse(points2[5])));
                    break;
                }
                if (flag == false) break;

                
                

                    sum = v1 + v2;
                    dif = v1 - v2;
                    mult = v1 * v2;

                    Console.WriteLine(v1);
                    Console.WriteLine(v2);
                    Console.WriteLine("Сумма векторов - {0}", Math.Round(sum,5));
                    Console.WriteLine("Разность векторов - {0}", Math.Round(dif,5));
                    Console.WriteLine("Произведение векторов - {0}", Math.Round(mult,5));
                    Console.ReadLine();
                 
            }
            while (true);
        }
    }
}
