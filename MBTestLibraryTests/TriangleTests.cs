using Microsoft.VisualStudio.TestTools.UnitTesting;
using MBTestLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MBTestLib.GeometrySolver;

namespace MBTestLib.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTest()
        {
            Triangle tr = new Triangle(4, 5, 6);
            Assert.AreEqual(tr.Side1, 4);
            Assert.AreEqual(tr.Side2, 5);
            Assert.AreEqual(tr.Side3, 6);
            Assert.ThrowsException<ArgumentException>(new Action(() => tr = new Triangle(1, 2, 1)));
        }

        [TestMethod()]
        public void CalcAreaTest()
        {
            Triangle tr = new Triangle(4, 5, 6);
            Assert.AreEqual(tr.CalcArea(), GeometrySolver.CalcTriangleArea(4, 5, 6));

            tr = new Triangle(7, 8, 9);
            Assert.AreEqual(tr.CalcArea(), GeometrySolver.CalcTriangleArea(7, 8, 9));
        }

        [TestMethod()]
        public void IsTrianlgeRightTest()
        {
            Assert.AreEqual(IsTriangleRight(3, 4, 5),true);
            Assert.AreEqual(IsTriangleRight(5, 3, 4), true);
            Assert.AreEqual(IsTriangleRight(3, 6, 5), false);

        }

        [TestMethod()]
        public void IsThisTrianlgeRightTest()
        {
            Triangle tr = new Triangle(3,4,5);
            Assert.AreEqual(tr.IsThisTriangleRight(), true);
            tr = new Triangle(5,3,4);
            Assert.AreEqual(tr.IsThisTriangleRight(), true);
            tr = new Triangle(3,6,5);
            Assert.AreEqual(tr.IsThisTriangleRight(), false);
        }

        [TestMethod()]
        public void IsTriangleWithSidesPossibleTest()
        {
            Assert.AreEqual(IsTriangleWithSidesPossible(1, 2, 3), false);
            Assert.AreEqual(IsTriangleWithSidesPossible(3, 2, 1), false);
            Assert.AreEqual(IsTriangleWithSidesPossible(2, 3, 1), false);
        }
    }
}