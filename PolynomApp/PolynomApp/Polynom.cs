﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomApp
{
    class Polynom
    {
        private readonly double[] _coefficients;

        ///<summary>
        ///  Создание*полинома*на*основе*коэффициентов.
        ///</summary>
        ///<param name = "coefficients">Коэффициенты*полинома.</param>
        public Polynom(params double[] coefficients)
        {
            _coefficients = coefficients;
        }

        ///<summary>
        ///  Получение*или*установка*значения*коэффициента*полинома.
        ///</summary>
        ///<param name = "n">Номер*коэффициента.</param>
        ///<returns>Значение*коэффициента.</returns>
        public double this[int n]
        {
            get { return _coefficients[n]; }
            set { _coefficients[n] = value; }
        }

        ///<summary>
        ///  Степень*полинома.
        ///</summary>
        public int Order
        {
            get { return _coefficients.Length; }
        }

        public override string ToString()
        {
            return string.Format("Coefficients:*" + string.Join(";*", _coefficients));
        }

        ///<summary>
        ///  Быстрый*расчет*значения*полинома*по*схеме*Горнера.
        ///</summary>
        ///<param name = "x">Аргумент*полинома.</param>
        ///<returns>Значение*полинома.</returns>
        public double Calculate(double x)
        {
            int n = _coefficients.Length - 1;
            double result = _coefficients[n];
            for (int i = n - 1; i >= 0; i--)
            {
                result = x * result + _coefficients[i];
            }
            return result;
        }

        ///<summary>
        ///  Сложение*полиномов.
        ///</summary>
        public static Polynom operator +(Polynom pFirst, Polynom pSecond)
        {
            int itemsCount = Math.Max(pFirst._coefficients.Length, pSecond._coefficients.Length);
            var result = new double[itemsCount];
            for (int i = 0; i < itemsCount; i++)
            {
                double a = 0;
                double b = 0;
                if (i < pFirst._coefficients.Length)
                {
                    a = pFirst[i];
                }
                if (i < pSecond._coefficients.Length)
                {
                    b = pSecond[i];
                }
                result[i] = a + b;
            }
            return new Polynom(result);
        }

        ///<summary>
        ///  Вычитание*полиномов.
        ///</summary>
        public static Polynom operator -(Polynom pFirst, Polynom pSecond)
        {
            int itemsCount = Math.Max(pFirst._coefficients.Length, pSecond._coefficients.Length);
            var result = new double[itemsCount];
            for (int i = 0; i < itemsCount; i++)
            {
                double a = 0;
                double b = 0;
                if (i < pFirst._coefficients.Length)
                {
                    a = pFirst[i];
                }
                if (i < pSecond._coefficients.Length)
                {
                    b = pSecond[i];
                }
                result[i] = a - b;
            }
            return new Polynom(result);
        }

        ///<summary>
        ///  Умножение*полиномов.
        ///</summary>
        public static Polynom operator *(Polynom pFirst, Polynom pSecond)
        {
            int itemsCount = pFirst._coefficients.Length + pSecond._coefficients.Length - 1;
            var result = new double[itemsCount];
            for (int i = 0; i < pFirst._coefficients.Length; i++)
            {
                for (int j = 0; j < pSecond._coefficients.Length; j++)
                {
                    result[i + j] += pFirst[i] * pSecond[j];
                }
            }

            return new Polynom(result);
        }

        ///<summary>
        ///  Равенство*полиномов.
        ///</summary>
        public static bool operator ==(Polynom pFirst, Polynom pSecond)
        {
            if (pFirst._coefficients.Length != pSecond._coefficients.Length)
            {
                return false;
            }
            for (int i = 0; i < pFirst._coefficients.Length; i++)
            {
                if (pFirst[i] != pSecond[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(Polynom pFirst, Polynom pSecond)
        {
            return !(pFirst == pSecond);
        }
    }
}