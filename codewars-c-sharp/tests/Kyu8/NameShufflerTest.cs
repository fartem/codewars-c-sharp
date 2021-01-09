using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu8;

namespace codewars_c_sharp.tests.Kyu8
{
    [TestFixture]
    public class NameShufflerTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(
                "McClane john",
                new NameShuffler("john McClane").Solution()
            );
            Assert.AreEqual(
                "jeggins Mary",
                new NameShuffler("Mary jeggins").Solution()
            );
            Assert.AreEqual(
                "jerry tom",
                new NameShuffler("tom jerry").Solution()
            );
        }
    }
}
