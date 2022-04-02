using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MBTestLib.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        [DataRow(0, 1, 1)]
        [DataRow(-1, 1, 1)]
        [DataRow(1, -1, 1)]
        [DataRow(1, 0, 1)]
        [DataRow(1, 1, -1)]
        [DataRow(1, 1, 0)]
        public void TriangleSidesZeroOrLessTest(double a, double b, double c)
        {
            Triangle trianlge;
            Assert.ThrowsException<ArgumentOutOfRangeException>(new Action(() => trianlge = new Triangle(a, b, c)));
        }

        [TestMethod()]
        [DataRow(2, 1, 1)]
        [DataRow(1, 2, 1)]
        [DataRow(1, 1, 2)]
        public void TriangleNotPossibleTest(double a, double b, double c)
        {
            Triangle tr;
            Assert.ThrowsException<ArgumentException>(new Action(() => tr = new Triangle(1, 2, 1)));
        }

        [TestMethod()]
        [DataRow(3, 4, 5)]
        [DataRow(5, 4, 3)]
        [DataRow(4, 3, 5)]
        [DataRow(4.4, 3.3, 5.5)]
        public void TriangleSidesSetCorrectTest(double a, double b, double c)
        {
            Triangle tr = new Triangle(a, b, c);
            Assert.AreEqual(a, tr.Side1, double.Epsilon);
            Assert.AreEqual(b, tr.Side2, double.Epsilon);
            Assert.AreEqual(c, tr.Side3, double.Epsilon);
        }

        [TestMethod()]
        [DataRow(3, 4, 5, 6)]
        [DataRow(5, 3, 4, 6)]
        [DataRow(3, 6, 5, 7.4833)]
        [DataRow(3, 6, 8, 7.6444)]
        public void CalcTriangleAreaTest(double a, double b, double c, double expected)
        {
            Triangle tr = new Triangle(a, b, c);
            Assert.AreEqual(expected, tr.Area);
        }

        [TestMethod()]
        [DataRow(3, 4, 5, true)]
        [DataRow(5, 3, 4, true)]
        [DataRow(3, 6, 5, false)]
        public void IsTriangleRightTest(double a, double b, double c, bool expected)
        {
            Triangle tr = new Triangle(a, b, c);
            Assert.AreEqual(tr.IsRight, expected);
        }
    }
}