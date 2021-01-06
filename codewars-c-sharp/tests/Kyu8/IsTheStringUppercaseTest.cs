using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu8;

namespace codewars_c_sharp.tests.Kyu8
{
    [TestFixture]
    public class IsTheStringUppercaseTest
    {
        [Test]
        public static void FixedTest()
        {
            Assert.AreEqual(
                false,
                new IsTheStringUppercase("c").Solution()
            );
            Assert.AreEqual(
                true,
                new IsTheStringUppercase("C").Solution()
            );
            Assert.AreEqual(
                false,
                new IsTheStringUppercase(
                    "hello I AM DONALD"
                ).Solution()
            );
            Assert.AreEqual(
                true,
                new IsTheStringUppercase(
                    "HELLO I AM DONALD"
                ).Solution()
            );
            Assert.AreEqual(
                false,
                new IsTheStringUppercase(
                    "ACSKLDFJSgSKLDFJSKLDFJ"
                ).Solution()
            );
            Assert.AreEqual(
                true,
                new IsTheStringUppercase(
                    "ACSKLDFJSGSKLDFJSKLDFJ"
                ).Solution()
            );
        }
    }
}
