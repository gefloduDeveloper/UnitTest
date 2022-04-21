using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        private Fundamentals.Math math;

        [SetUp]
        public void SetUp()
        {
            math = new Fundamentals.Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            var result = math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var result = math.Max(2,1);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var result = math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            var result = math.Max(2, 2);
            Assert.That(result, Is.EqualTo(2));
        }

    }
}
