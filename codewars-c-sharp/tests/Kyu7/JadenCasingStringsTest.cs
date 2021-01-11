using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu7;

namespace codewars_c_sharp.tests.Kyu7
{
    [TestFixture]
    public class JadenCasingStringsTest
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual(
                "How Can Mirrors Be Real If Our Eyes Aren't Real",
                new JadenCasingStrings(
                    "How can mirrors be real if our eyes aren't real"
                ).Solution()
            );
        }
    }
}
