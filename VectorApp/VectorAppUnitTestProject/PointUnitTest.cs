using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorApp;

namespace VectorAppUnitTestProject
{
    [TestClass]
    public class PointUnitTest
    {
        [TestMethod]
        public void FindPow_p1()
        {
            Point p1 = new Point(2, -1, 2);
            double expected = 9;

            Assert.AreEqual(expected, p1.FindPow, null, "Значения не равны");
        }
    }
}
