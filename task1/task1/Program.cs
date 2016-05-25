using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    static class Formatting
    {
        public static void PrintOut(string s)
        {
            int i=0;
            string[] separators = { ","," ","\n"};
            string[] words = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            while(i < words.Length)
            {
                //Console.WriteLine(words[i]);
                Console.WriteLine("X:{0} Y:{1}", double.Parse(words[i]), double.Parse(words[i+1]));
                i+=2;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char i;
            string s;
            
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
                        { Console.WriteLine("Ну йобана :с"); Console.ReadKey(); break; }
                        else { Formatting.PrintOut(s); }
                    }
                    break;
                case '2':
                    Console.WriteLine("Введите имя файла:");
                    s=Console.ReadLine();
                    if(File.Exists(s))
                    {Formatting.PrintOut(File.ReadAllText(s)); Console.ReadKey(); }
                    else { Console.WriteLine("Ну йобана :с"); Console.ReadKey(); }
                    break;
                default:
                    Console.WriteLine("Ну йобана :с");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
