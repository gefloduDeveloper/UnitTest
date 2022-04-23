using NUnit.Framework;
using System;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        [TestCase(9,"Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(45, "FizzBuzz")]
        [TestCase(4, "4")]
        public void GetOutput_WhenCalled_ReturnTheRightOutput(int a, string expectedResult)
        {
            var result = FizzBuzz.GetOutput(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}
