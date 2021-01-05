using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu8;

namespace codewars_c_sharp.tests.Kyu8
{
    [TestFixture]
    class GetASCIIValueOfCharacterTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(
                65,
                new GetASCIIValueOfCharacter('A').Solution()
            );
            Assert.AreEqual(
                32,
                new GetASCIIValueOfCharacter(' ').Solution()
            );
            Assert.AreEqual(
                33,
                new GetASCIIValueOfCharacter('!').Solution()
            );
        }
    }
}
