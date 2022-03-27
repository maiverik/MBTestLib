using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MBTestLib;
using System.Collections.Generic;

namespace MBTestLib.Tests
{
    [TestClass()]
    public class GeometrySolverTests
    {

        [TestMethod()]
        public void CalcCircleAreaByRadiusTest()
        {

            Assert.AreEqual(GeometrySolver.CalcCircleAreaByRadius(1), 3.1415926535897931);
            Assert.AreEqual(GeometrySolver.CalcCircleAreaByRadius(20), 1256.6370614359173);
            Assert.AreEqual(GeometrySolver.CalcCircleAreaByRadius(400), 502654.82457436691);

            Assert.ThrowsException<ArgumentOutOfRangeException>(new Action(() => GeometrySolver.CalcCircleAreaByRadius(-1)));

        }

        [TestMethod()]
        public void CalcTriangleAreaBySidesTest()
        {

            Assert.AreEqual(GeometrySolver.CalcTriangleArea(3, 4, 5), 6);
            Assert.AreEqual(GeometrySolver.CalcTriangleArea(5, 3, 4), 6);
            Assert.AreEqual(GeometrySolver.CalcTriangleArea(3, 6, 5), 7.4833147735478827);
            Assert.AreEqual(GeometrySolver.CalcTriangleArea(3, 6, 8), 7.6444424257103281);

            Assert.ThrowsException<ArgumentOutOfRangeException>(new Action(() => GeometrySolver.CalcTriangleArea(-1, 1, 1)));
            Assert.ThrowsException<ArgumentOutOfRangeException>(new Action(() => GeometrySolver.CalcTriangleArea(1, -1, 1)));
            Assert.ThrowsException<ArgumentOutOfRangeException>(new Action(() => GeometrySolver.CalcTriangleArea(1, 1, -1)));
        }

        [TestMethod()]
        public void CreateFiguresListTest()
        {
            Assert.AreEqual(GeometrySolver.CreateFiguresList() > 0, true);
        }
    }
}