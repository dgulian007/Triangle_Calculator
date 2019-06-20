using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Triangle;

namespace TriangleTest
{
    [TestFixture]
    public class TriangleUnitTest
    {
        [Test]
        public void EquilateralTriangleTest()
        {
            String triangleType = TriangleSolver.Analyze(3, 3, 3);
            StringAssert.Contains("EQUILATERAL TRIANGLE", triangleType);
        }

        [Test]
        public void IsoceleslTriangleTest()
        {
            String triangleType = TriangleSolver.Analyze(2, 4, 4);
            StringAssert.Contains("ISOCELES TRIANGLE", triangleType);
        }

        [Test]
        public void ScaleneTriangleTest()
        {
            String triangleType = TriangleSolver.Analyze(3, 5, 4);
            StringAssert.Contains("SCALENE TRIANGLE", triangleType);
        }

        [Test]
        public void InvalidTriangleTest()
        {
            String triangleType = TriangleSolver.Analyze(0, 1, 2);
            StringAssert.Contains("INVALID", triangleType);
        }

        [Test]
        public void ValidTriangleTest() 
        {
            String triangleType = TriangleSolver.Analyze(2, 5, 4);
            StringAssert.DoesNotContain("INVALID", triangleType);
        }

        [Test]
        public void NegativeInputTriangle()
        {
            String triangleType = TriangleSolver.Analyze(-2, 5, -4);
            StringAssert.Contains("INVALID", triangleType);
        }

        [Test]
        public void PositiveInputTriangle()
        {
            String triangleType = TriangleSolver.Analyze(2, 5, 4);
            StringAssert.DoesNotContain("INVALID", triangleType);
        }

        [Test]
        public void ZeroInputTriangle()
        {
            String triangleType = TriangleSolver.Analyze(0, 0, 0);
            StringAssert.Contains("INVALID", triangleType);
        }

    }
}
