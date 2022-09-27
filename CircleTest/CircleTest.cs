using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculationLib;

namespace Calculation.Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void AreaTest()
        {
            double r = 5;
            double expected = 78.53981633974483;

            Circle circle = new Circle(r);
            double result = circle.GetArea();

            Assert.AreEqual(expected, result);
        }
    }
}