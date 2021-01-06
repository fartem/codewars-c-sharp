using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu8;

namespace codewars_c_sharp.tests.Kyu8
{
    [TestFixture]
    public class BinToDecimalTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(
                0,
                new BinToDecimal("0").Solution()
            );
            Assert.AreEqual(
                1,
                new BinToDecimal("1").Solution()
            );
            Assert.AreEqual(
                2,
                new BinToDecimal("10").Solution()
            );
            Assert.AreEqual(
                3,
                new BinToDecimal("11").Solution()
            );
            Assert.AreEqual(
                6,
                new BinToDecimal("110").Solution()
            );
        }
    }
}
