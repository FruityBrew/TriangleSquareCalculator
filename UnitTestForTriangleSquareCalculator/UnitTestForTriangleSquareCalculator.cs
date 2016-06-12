using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XCompanyLib;

namespace UnitTestForTriangleSquareCalculator
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BadArguments()
        {
            XTriangleSquareCalculator.TriangleSqureCalculate(-3, 4, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotRightTriangle()
        {
            XTriangleSquareCalculator.TriangleSqureCalculate(12, 11, 13);
        }

        [TestMethod]
        public void RightTriangleArgSequence_1()
        {
            Assert.AreEqual(XTriangleSquareCalculator.TriangleSqureCalculate(7, 24, 25), 84);
        }

        [TestMethod]
        public void RightTriangleArgSequence_2()
        {
            Assert.AreEqual(XTriangleSquareCalculator.TriangleSqureCalculate(5, 4, 3), 6);
        }

        [TestMethod]
        public void RightTriangleArgSequence_3()
        {
            Assert.AreEqual(XTriangleSquareCalculator.TriangleSqureCalculate(12, 13, 5), 30);
        }


    }
}
