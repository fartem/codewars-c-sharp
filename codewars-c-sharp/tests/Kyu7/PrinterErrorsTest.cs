using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu7;

namespace codewars_c_sharp.tests.Kyu7
{
    [TestFixture]
    public class PrinterErrorsTest
    {
        [Test]
        public static void test1()
        {
            Assert.AreEqual(
                "3/56",
                new PrinterErrors(
                    "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"
                ).Solution()
            );
        }
    }
}
