using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu8;

namespace codewars_c_sharp.tests.Kyu8
{
    [TestFixture]
    class CanWeDivideItTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(
                true,
                new CanWeDivideIt(-12, 2, 6).Solution()
            );
            Assert.AreEqual(
                false,
                new CanWeDivideIt(-12, 2, -5).Solution()
            );
            Assert.AreEqual(
                false,
                new CanWeDivideIt(-45, 1, 6).Solution()
            );
            Assert.AreEqual(
                true,
                new CanWeDivideIt(45, 5, 15).Solution()
            );
            Assert.AreEqual(
                true,
                new CanWeDivideIt(4, 1, 4).Solution()
            );
            Assert.AreEqual(
                true,
                new CanWeDivideIt(15, -5, 3).Solution()
            );
        }
    }
}

