using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolynomApp;

namespace PolynomAppUnitTest
{
    [TestClass]
    public class PolynomUnitTest
    {
        [TestMethod]
        public void Equ_p1_p2()
        {
            Polynom p1 = new Polynom(1, 2, 3);
            Polynom p2 = new Polynom(1, 2, 3);

            bool expected = true;

            Assert.AreEqual(expected, p1 == p2, "Значения не равны!");
        }
        [TestMethod]
        public void Sum_p1_p2()
        {
            Polynom p1 = new Polynom(1, 2, 3);
            Polynom p2 = new Polynom(1, 2, 3);

            Polynom expected = new Polynom(2, 4, 6);

            Assert.AreEqual(expected, p1 + p2, "Значения не равны!");
        }
        [TestMethod]
        public void Dif_p1_p2()
        {
            Polynom p1 = new Polynom(1, 2, 3);
            Polynom p2 = new Polynom(1, 2, 3);

            Polynom expected = new Polynom(0, 0, 0);

            Assert.AreEqual(expected, p1 - p2, "Значения не равны!");
        }
        [TestMethod]
        public void Mult_p1_p2()
        {
            Polynom p1 = new Polynom(1, 2, 3);
            Polynom p2 = new Polynom(1, 2, 3);

            Polynom expected = new Polynom(1, 2, 3, 2, 4, 6, 3, 6, 9);

            Assert.AreEqual(expected, p1 * p2, "Значения не совпадают!");
         }
    }
    
}
