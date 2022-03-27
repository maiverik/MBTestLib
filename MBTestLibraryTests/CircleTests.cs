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
    public class CircleTests
    {
        [TestMethod()]
        public void CircleTest()
        {
            const int r = 4;
            Circle cr = new Circle(r);
            Assert.IsNotNull(cr);
            Assert.AreEqual(cr.Radius, r);
        }

        [TestMethod()]
        public void CalcAreaTest()
        {
            for (int r = 4; r <= 6; r++)
            {
                Circle tr = new Circle(r);
                Assert.AreEqual(tr.CalcArea(), GeometrySolver.CalcCircleAreaByRadius(r));
            }
            
        }
    }
}