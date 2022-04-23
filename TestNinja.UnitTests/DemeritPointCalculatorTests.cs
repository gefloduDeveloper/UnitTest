using NUnit.Framework;
using System;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class DemeritPointCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_outOfBoundsSpeeds_ThrowsAnException(int a)
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            Assert.That(() => demeritPointsCalculator.CalculateDemeritPoints(a), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(30, 0)]
        [TestCase(70, 1)]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        public void CalculateDemeritPoints_InBoundsSpeeds_ReturnsDemeritPoints(int a, int demeritPoints)
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            var result = demeritPointsCalculator.CalculateDemeritPoints(a);
            Assert.That(result, Is.EqualTo(demeritPoints));
        }
    }
}
