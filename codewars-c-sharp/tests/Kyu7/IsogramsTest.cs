using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu7;

namespace codewars_c_sharp.tests.Kyu7
{
    [TestFixture]
    class IsogramsTest
    {
        [Test]
        public void basicTests()
        {
            Assert.AreEqual(
                true,
                new Isograms("Dermatoglyphics").Solution()
            );
            Assert.AreEqual(
                true,
                new Isograms("isogram").Solution()
            );
            Assert.AreEqual(
                false,
                new Isograms("moose").Solution()
            );
            Assert.AreEqual(
                false,
                new Isograms("isIsogram").Solution()
            );
            Assert.AreEqual(
                false,
                new Isograms("aba").Solution()
            );
            Assert.AreEqual(
                false,
                new Isograms("moOse").Solution()
            );
            Assert.AreEqual(
               true,
               new Isograms("thumbscrewjapingly").Solution()
            );
            Assert.AreEqual(
               true,
               new Isograms("").Solution()
            );
        }
    }
}
