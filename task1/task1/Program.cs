using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
         
        static void Main(string[] args)
        {
            char i;
            string s;
            List<Point> point_list = new List<Point>();
            
                     
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Ввод данных через консоль");
            Console.WriteLine("2. Загрузка данных из файла");
            i = char.Parse(Console.ReadLine());
            switch (i)
            {
                case '1':
                    while (true)
                    {
                        s = Console.ReadLine();
                        if (String.IsNullOrEmpty(s) == true)
                        { Console.WriteLine("Нажмите любую клавишу для продолжения."); Console.ReadKey(); break; }
                        else { ParseLine.SplitInput(point_list,s); }
                    }          
                    break;
                case '2':
                    Console.WriteLine("Введите имя файла:");
                    s=Console.ReadLine();
                    if(File.Exists(s))
                    {ParseLine.SplitInput(point_list,File.ReadAllText(s)); Console.ReadKey(); }
                    else { Console.WriteLine("Нажмите любую клавишу для продолжения."); Console.ReadKey(); }
                    break;
                default:
                    Console.WriteLine("Нажмите любую клавишу для продолжения.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
