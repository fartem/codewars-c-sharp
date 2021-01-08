using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu6;

namespace codewars_c_sharp.tests.Kyu6
{
    [TestFixture]
    public class ReplaceWithAlphabetPositionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(
                "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11",
                new ReplaceWithAlphabetPosition(
                    "The sunset sets at twelve o' clock."
                ).Solution()
            );
            Assert.AreEqual(
                "20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20",
                new ReplaceWithAlphabetPosition(
                    "The narwhal bacons at midnight."
                ).Solution()
            );
        }
    }
}
