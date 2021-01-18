using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu8;

namespace codewars_c_sharp.tests.Kyu8
{
    [TestFixture]
    public class VowelRemoverTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(
                "hll",
                new VowelRemover(
                    "hello"
                ).Solution()
            );
            Assert.AreEqual(
                "hw r y tdy?",
                new VowelRemover(
                    "how are you today?"
                ).Solution()
            );
            Assert.AreEqual(
                "cmpln",
                new VowelRemover(
                    "complain"
                ).Solution()
            );
            Assert.AreEqual(
                "nvr",
                new VowelRemover(
                    "never"
                ).Solution()
            );
        }
    }
}
