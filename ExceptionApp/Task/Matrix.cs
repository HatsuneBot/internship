using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Matrix
    {
        private int row, column;
        private double[,] matrix;

        public Matrix(int _n, int _m)
        {
            row = _n;
            column = _m;
            matrix = new double[row, column];
        }

        public Matrix(int _n)
        {
            row = _n;
            column = _n;
            matrix = new double[row, column];
        }

        public double this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
           
            try
            {
                if (a.row != b.row || a.column != b.column)
                {
                    throw new Exception("Не совпадают размеры матрицы!");                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            Matrix sum = new Matrix(a.row, a.column);
            for (int i = 0; i < a.row; i++)
                for (int j = 0; j < a.column; j++)
                    sum[i, j] = a[i, j] + b[i, j];
            return sum;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            try
            {
                if (a.row != b.row || a.column != b.column)
                {
                    throw new Exception("Не совпадают размеры матрицы!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            Matrix dif = new Matrix(a.row, a.column);
            for (int i = 0; i < a.row; i++)
                for (int j = 0; j < a.column; j++)
                    dif[i, j] = a[i, j] - b[i, j];
            return dif;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            try
            {
                if (a.column != b.row)
                {
                    throw new Exception("Не совпадают размеры матрицы!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            Matrix mult = new Matrix(a.row, b.column);
            double sum;
            for (int i = 0; i < mult.row; i++)
                for (int j = 0; j < mult.column; j++)
                {
                    sum = 0;
                    for (int k = 0; k < a.column; k++)
                        sum += a[i, k] * b[k, j];
                    mult[i, j] = sum;
                }
            return mult;
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                    Console.Write("{0}  ", this[i, j]);
                Console.Write("\n");
            }

        }

        public override bool Equals(object obj)
        {
            return obj.ToString() == ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            try
            {
                if (a.row != b.row || a.column != b.column)
                {
                    throw new Exception("Не совпадают размеры матрицы!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 0; i < a.row; i++)
                for (int j = 0; j < a.column; j++)
                    if (a[i, j] != b[i, j]) return false;
            return true;
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }
    }
}
