using NUnit.Framework;
using System;
using Codewars._4kyu;

namespace Codewars.tests._4kyu
{
    [TestFixture]
    class RectangleRotationTests
    {

        [Test]
        public void BasicTests()
        {
            var kata = new RectangleRotation();

            Assert.AreEqual(23, kata.RectangleRotationCount(6, 4));

            Assert.AreEqual(65, kata.RectangleRotationCount(30, 2));

            Assert.AreEqual(49, kata.RectangleRotationCount(8, 6));

            Assert.AreEqual(333, kata.RectangleRotationCount(16, 20));
        }
    }
}
