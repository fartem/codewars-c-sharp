using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu7;

namespace codewars_c_sharp.tests.Kyu7
{
    [TestFixture]
    public class OnesAndZerosTest
    {
        [Test]
        public void BasicTesting()
        {
            Assert.AreEqual(
                0,
                new OnesAndZeros(
                    new int[] { 0, 0, 0, 0 }
                ).Solution()
            );
            Assert.AreEqual(
                15,
                new OnesAndZeros(
                    new int[] { 1, 1, 1, 1 }
                ).Solution()
            );
            Assert.AreEqual(
                6,
                new OnesAndZeros(
                    new int[] { 0, 1, 1, 0 }
                ).Solution()
            );
            Assert.AreEqual(
                5,
                new OnesAndZeros(
                    new int[] { 0, 1, 0, 1 }
                ).Solution()
            );
        }
    }
}
