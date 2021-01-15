using System;
using NUnit.Framework;
using codewars_c_sharp.src.Kyu6;

namespace codewars_c_sharp.tests.Kyu6
{
    [TestFixture]
    public class CamelCaseMethodTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(
                "TestCase",
                "test case".CamelCase()
            );
            Assert.AreEqual(
                "CamelCaseMethod",
                "camel case method".CamelCase()
            );
            Assert.AreEqual(
                "SayHello",
                "say hello".CamelCase()
            );
            Assert.AreEqual(
                "CamelCaseWord",
                " camel case word".CamelCase()
            );
            Assert.AreEqual(
                "",
                "".CamelCase()
            );
        }
    }
}
