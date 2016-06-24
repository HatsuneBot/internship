using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, cols;
            Random rand = new Random();
            while (true)
            {
                Console.WriteLine("Введите количество строк матрицы А:");
                row = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество столбцов матрицы А:");
                cols = int.Parse(Console.ReadLine());

                Matrix a = new Matrix(row, cols);
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < cols; j++)
                        a[i, j] = rand.Next(-5, 5);
                a.PrintMatrix();

                Console.WriteLine("Введите количество строк матрицы B:");
                row = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество столбцов матрицы B:");
                cols = int.Parse(Console.ReadLine());

                Matrix b = new Matrix(row, cols);
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < cols; j++)
                        b[i, j] = rand.Next(-5, 5);
                b.PrintMatrix();

                Console.WriteLine("Сумма матриц:");
                try
                { (a + b).PrintMatrix(); }
                catch (NullReferenceException) { Console.WriteLine("Невозможно отобразить результат!"); }
                Console.WriteLine("Разность матриц:");
                try
                { (a - b).PrintMatrix(); }
                catch (NullReferenceException) { Console.WriteLine("Невозможно отобразить результат!"); }
                Console.WriteLine("Произведение матриц:");
                try
                { (a * b).PrintMatrix(); }
                catch (NullReferenceException) { Console.WriteLine("Невозможно отобразить результат!"); }
            }
        }
    }
}
