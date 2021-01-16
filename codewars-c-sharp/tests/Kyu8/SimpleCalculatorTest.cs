using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu8;

namespace codewars_c_sharp.tests.Kyu8
{
    [TestFixture]
    public class SimpleCalculatorTest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(
                8,
                new SimpleCalculator(6, 2, '+').Solution()
            );
            Assert.AreEqual(
                1,
                new SimpleCalculator(4, 3, '-').Solution()
            );
            Assert.AreEqual(
                25,
                new SimpleCalculator(5, 5, '*').Solution()
            );
            Assert.AreEqual(
                1.25,
                new SimpleCalculator(5, 4, '/').Solution()
            );
        }

        [Test]
        public void ErrorTest()
        {
            Assert.Throws<ArgumentException>(
                () => new SimpleCalculator(6, 2, '&').Solution()
            );
        }
    }
}
