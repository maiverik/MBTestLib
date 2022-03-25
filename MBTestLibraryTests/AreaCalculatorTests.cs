using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.Collections.Generic;

namespace MBTestLib.Tests
{
    [TestClass()]
    public class AreaCalculatorTests
    {
        [TestMethod()]
        public void CalcCircleAreaByRadiusTest()
        {

            Dictionary<double, double> testList = new Dictionary<double, double>();
            testList.Add(1, 3.1415926535897931);
            testList.Add(20, 1256.6370614359173);
            testList.Add(400, 502654.82457436691);

            foreach (var r in testList)
            {
                Assert.AreEqual(AreaCalculator.CalcCircleAreaByRadius(r.Key), r.Value);
            }

            Assert.ThrowsException<ArgumentOutOfRangeException>(new Action(() => AreaCalculator.CalcCircleAreaByRadius(-1)));

        }

        [TestMethod()]
        public void CalcTriangleAreaBySidesTest()
        {
            Dictionary<double[], double> testList = new Dictionary<double[], double>();
            testList.Add(new double[] { 3, 4, 5 }, 6);
            testList.Add(new double[] { 5, 3, 4 }, 6);
            testList.Add(new double[] { 3, 6, 5 }, 7.4833147735478827);
            testList.Add(new double[] { 3, 6, 8 }, 7.6444424257103281);
            foreach (var r in testList)
            {
                Assert.AreEqual(AreaCalculator.CalcTriangleArea(r.Key[0], r.Key[1], r.Key[2]), r.Value);
            }

            Assert.ThrowsException<ArgumentOutOfRangeException>(new Action(() => AreaCalculator.CalcTriangleArea(-1, 1, 1)));
            Assert.ThrowsException<ArgumentOutOfRangeException>(new Action(() => AreaCalculator.CalcTriangleArea(1, -1, 1)));
            Assert.ThrowsException<ArgumentOutOfRangeException>(new Action(() => AreaCalculator.CalcTriangleArea(1, 1, -1)));
        }

        [TestMethod()]
        public void AddFigureTest()
        {
            var AC = new AreaCalculator();
            Triangle tr = new Triangle(4,5,6);
            AC.AddFigure(tr);
            Assert.AreEqual(AC.Figures.Count, 1);
            Assert.AreEqual(AC.Figures[0], tr);
        }
    }
}