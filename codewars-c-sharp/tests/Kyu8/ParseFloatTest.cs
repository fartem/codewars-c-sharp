using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu8;

namespace codewars_c_sharp.tests.Kyu8
{
    [TestFixture]
    public class ParseFloatTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(
                1.0d,
                new ParseFloat("1").Solution()
            );
        }
    }
}
