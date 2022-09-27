using CalculationLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void AreaTest()
        {
            double a = 3;
            double b = 5;
            double c = 6;
            double expected = 7.483314773547883;

            Triangle triangle = new Triangle(a, b, c);
            double result = triangle.GetArea();

            Assert.AreEqual(expected, result);
        }
    }
}
