using codewars_c_sharp.src.Kyu8;
using NUnit.Framework;

namespace codewars_c_sharp.tests.Kyu8
{
    [TestFixture]
    class CanWeDivideItTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(true, new CanWeDivideIt(-12, 2, 6));
            Assert.AreEqual(false, new CanWeDivideIt(-12, 2, -5));
            Assert.AreEqual(false, new CanWeDivideIt(-45, 1, 6));
            Assert.AreEqual(true, new CanWeDivideIt(45, 5, 15));
            Assert.AreEqual(true, new CanWeDivideIt(4, 1, 4));
            Assert.AreEqual(true, new CanWeDivideIt(15, -5, 3));
        }
    }
}
