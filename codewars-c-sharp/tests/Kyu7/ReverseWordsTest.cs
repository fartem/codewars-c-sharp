using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu7;

namespace codewars_c_sharp.tests.Kyu7
{
    [TestFixture]
    public class ReverseWordsTest
    {
        [Test]
        public void Example()
        {
            Assert.AreEqual(
                "sihT si na !elpmaxe",
                new ReverseWords("This is an example!").Solution()
            );
        }
    }
}
