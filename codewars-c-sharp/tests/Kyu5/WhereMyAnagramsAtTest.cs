using System;
using System.Collections.Generic;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu5;

namespace codewars_c_sharp.tests.Kyu5
{
    [TestFixture]
    public class WhereMyAnagramsAtTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(
                new List<string> { "a" },
                new WhereMyAnagramsAt(
                    "a",
                    new List<string> { "a", "b", "c", "d" }
                ).Solution()
            );
            Assert.AreEqual(
                new List<string> { "carer", "arcre", "carre" },
                new WhereMyAnagramsAt(
                    "racer",
                    new List<string> {
                        "carer",
                        "arcre",
                        "carre",
                        "racrs",
                        "racers",
                        "arceer",
                        "raccer",
                        "carrer",
                        "cerarr"
                    }
                ).Solution()
            );
        }
    }
}
