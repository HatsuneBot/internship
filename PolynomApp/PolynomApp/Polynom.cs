using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomApp
{
    public class Polynom
    {
        private double[] _coefficients;

        public Polynom(params double[] coefficients)
        {
            _coefficients = coefficients;
        }

        public double this[int n]
        {
            get { return _coefficients[n]; }
            set { _coefficients[n] = value; }
        }

        public int Order
        {
            get { return _coefficients.Length; }
        }

        public override string ToString()
        {
            return string.Format("Coefficients:*" + string.Join(";*", _coefficients));
        }


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

        public static Polynom operator *(Polynom pFirst, Polynom pSecond)
        {
            int itemsCount = pFirst._coefficients.Length * pSecond._coefficients.Length;
            var result = new double[itemsCount];
            int k = 0;
            for (int i = 0; i < pFirst._coefficients.Length; i++)
            {
                for (int j = 0; j < pSecond._coefficients.Length; j++)
                {
                    result[k] += pFirst[i] * pSecond[j];
                    k++;
                }
            }

            return new Polynom(result);
        }


        public override bool Equals(object obj)
        {
            return obj.ToString()== ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

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
