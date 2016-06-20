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
            do
            {
                string[] separators = { ",", " ", "\n" };
                try
                {
                    Console.WriteLine("Введите первый полином:");
                    string s = Console.ReadLine();
                    if (string.IsNullOrEmpty(s) == true) break;
                    string[] poly1 = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    Console.WriteLine("Введите второй полином:");
                    string[] poly2 = Console.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries);

                    double[] input1, input2;
                    input1 = new double[poly1.Length];
                    input2 = new double[poly2.Length];

                    for (int i = 0; i < poly1.Length; i++)
                    {
                        input1[i] = double.Parse(poly1[i]);
                    }

                    for (int i = 0; i < poly2.Length; i++)
                    {
                        input2[i] = double.Parse(poly2[i]);
                    }

                    Polynom p1 = new Polynom(input1);
                    Polynom p2 = new Polynom(input2);

                    Console.WriteLine("Сумма полиномов:{0} ", p1 + p2);
                    Console.WriteLine("Разность полиномов:{0} ", p1 - p2);
                    Console.WriteLine("Произведение полиномов:{0} ", p1 * p2);
                    Console.WriteLine("Равенство полиномов:{0} ", p1 == p2);
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неправильно введены данные! Введите целое число!");
                }
            } while (true);
        }
    }
}
