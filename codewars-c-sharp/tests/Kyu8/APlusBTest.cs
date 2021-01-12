using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu8;

namespace codewars_c_sharp.tests.Kyu8
{
    [TestFixture]
    public class APlusBTest
    {
        [Test]
        public void testSum()
        {
            Assert.AreEqual(
                3,
                new APlusB(1, 2).Solution()
            );
        }
    }
}
