using Microsoft.VisualStudio.TestTools.UnitTesting;
using MBTestLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTestLib.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTest()
        {
            
            Triangle tr = new Triangle(4, 5, 6);
            Assert.AreEqual(tr.side1, 4);
            Assert.AreEqual(tr.side2, 5);
            Assert.AreEqual(tr.side3, 6);
        }

        [TestMethod()]
        public void CalcAreaTest()
        {
            Triangle tr = new Triangle(4, 5, 6);
            Assert.AreEqual(tr.CalcArea(), AreaCalculator.CalcTriangleArea(4, 5, 6));

            tr = new Triangle(7, 8, 9);
            Assert.AreEqual(tr.CalcArea(), AreaCalculator.CalcTriangleArea(7, 8, 9));
        }

        [TestMethod()]
        public void IsTrianlgeRightTest()
        {
            
            Triangle tr = new Triangle(4, 5, 6);
            Dictionary<double[], bool> testList = new Dictionary<double[], bool>();
            testList.Add(new double[] { 3, 4, 5 }, true);
            testList.Add(new double[] { 5, 3, 4 }, true);
            testList.Add(new double[] { 3, 6, 5 }, false);
            foreach (var r in testList)
            {
                tr = new Triangle(r.Key[0], r.Key[1], r.Key[2]);
                Assert.AreEqual(tr.IsTriangleRight(), r.Value);
            }
        }
        [TestMethod()]
        public void IsTriangleWithSidesPossibleTest()
        {
            Assert.AreEqual(Triangle.IsTriangleWithSidesPossible(1, 2, 3), false);
            Assert.AreEqual(Triangle.IsTriangleWithSidesPossible(3, 2, 1), false);
            Assert.AreEqual(Triangle.IsTriangleWithSidesPossible(2, 3, 1), false);
        }
    }
}