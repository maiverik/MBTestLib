using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MBTestLib.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        [DataRow(0)]
        [DataRow(-1)]
        public void CircleRadiusZeroOrLessTest(double r)
        {
            Circle circle;
            Assert.ThrowsException<ArgumentOutOfRangeException>(new Action(() => circle = new Circle(r)));
        }

        [TestMethod()]
        [DataRow(1)]
        [DataRow(2.5)]
        public void CircleRadiusSetCorrectTest(double r)
        {
            Circle cr = new Circle(r);
            Assert.AreEqual(r, cr.Radius);
        }

        [TestMethod()]
        [DataRow(1, 3.1416)]
        [DataRow(20, 1256.6371)]
        [DataRow(2.5, 19.6350)]
        public void CalcCircleAreaTest(double r, double expected)
        {
            var circle = new Circle(r);
            Assert.AreEqual(expected, circle.Area);
        }
    }
}