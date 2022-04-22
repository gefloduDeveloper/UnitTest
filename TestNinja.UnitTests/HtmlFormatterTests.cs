using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShoulEncloseTheStringWithStrongElements()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("abc");
            //Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);
            //More General
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            Assert.That(result, Does.Contain("abc").IgnoreCase);
        }
    }
}
