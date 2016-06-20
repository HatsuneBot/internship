using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorApp;

namespace VectorAppUnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Sum_v1_v2()
        {
            Vector v1 = new Vector(new Point(2, 0, 2), new Point(0, 1, 0));
            Vector v2 = new Vector(new Point(0, 1, 0), new Point(2, 0, 2));
            double expected = 6;

            double sum = v1 + v2;

            Assert.AreEqual(expected, sum,null,"Значения не равны.");
        }

        [TestMethod]
        public void Dif_v1_v2()
        {
            Vector v1 = new Vector(new Point(2, 0, 2), new Point(0, 1, 0));
            Vector v2 = new Vector(new Point(0, 1, 0), new Point(2, 0, 2));
            double expected = 0;

            double dif = v1 - v2;

            Assert.AreEqual(expected, dif, null, "Значения не равны");
        }
        [TestMethod]
        public void Mult_v1_v2()
        {
            Vector v1 = new Vector(new Point(2, 0, 2), new Point(0, 1, 0));
            Vector v2 = new Vector(new Point(0, 1, 0), new Point(2, 0, 2));
            double expected = 9;

            double mult = v1 * v2;

            Assert.AreEqual(expected, mult, null, "Значения не равны");
        }
    }
}
