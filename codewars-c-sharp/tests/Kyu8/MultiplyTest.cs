using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu8;

namespace codewars_c_sharp.tests.Kyu8
{
    [TestFixture]
    public class MultiplyTest
    {
        [Test]
        public void SimpleTest()
        {
            Assert.AreEqual(
                35,
                new Multiply(7, 5).Solution()
            );
        }
    }
}
