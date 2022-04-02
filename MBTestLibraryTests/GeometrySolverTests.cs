using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static MBTestLib.GeometrySolver;

namespace MBTestLib.Tests
{
    [TestClass()]
    public class GeometrySolverTests
    {
        [TestMethod()]
        [DataRow(3, 4, 5, 6)]
        [DataRow(5, 3, 4, 6)]
        [DataRow(3, 6, 5, 7.4833)]
        [DataRow(3, 6, 8, 7.6444)]
        public void CalcTriangleAreaTest(double a, double b, double c, double expected)
        {
            Assert.AreEqual(expected, CalculateTriangleArea(a, b, c));
        }

        [TestMethod()]
        [DataRow(3, 4, 5, true)]
        [DataRow(5, 3, 4, true)]
        [DataRow(3, 6, 5, false)]
        public void IsTriangleRightTest(double a, double b, double c, bool expected)
        {
            Assert.AreEqual(expected, IsTriangleRight(a, b, c));
        }

        [TestMethod()]
        [DataRow(1, 3.1416)]
        [DataRow(20, 1256.6371)]
        [DataRow(2.5, 19.6350)]
        public void CalcCircleAreaTest(double r, double expected)
        {
            Assert.AreEqual(expected, CalculateCircleArea(r));
        }

        [TestMethod()]
        [DataRow(1)]
        [DataRow(2.5)]
        public void GetCircleFigureAreaTest(double r)
        {
            var cr = new Circle(r);
            Assert.AreEqual(cr.Area, GetFigureArea(cr));
        }

        [TestMethod()]
        [DataRow(3, 4, 5)]
        [DataRow(5, 3, 6)]
        public void GetTriangleFigureAreaTest(double a, double b, double c)
        {
            var tr = new Triangle(a, b, c);
            Assert.AreEqual(tr.Area, GetFigureArea(tr));
        }
    }
}