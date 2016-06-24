using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;

namespace ExceprionAppUnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void SumM1M2()
        {
            Matrix a = new Matrix(3);
            Matrix b = new Matrix(3);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = 1;
                    b[i, j] = 2;
                }

            Matrix exp = new Matrix(3);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    exp[i, j] = 3;

            Assert.AreEqual(exp, a + b, null, "Значения не равны");
        }
        [TestMethod]
        public void DifM1M2()
        {
            Matrix a = new Matrix(3);
            Matrix b = new Matrix(3);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = 1;
                    b[i, j] = 2;
                }

            Matrix exp = new Matrix(3);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    exp[i, j] = -1;

            Assert.AreEqual(exp, a - b, null, "Значения не равны");
        }
        [TestMethod]
        public void MultM1M2()
        {
            Matrix a = new Matrix(3);
            Matrix b = new Matrix(3);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = 1;
                    b[i, j] = 2;
                }

            Matrix exp = new Matrix(3);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    exp[i, j] = 6;

            Assert.AreEqual(exp, a - b, null, "Значения не равны");
        }
    }
}
