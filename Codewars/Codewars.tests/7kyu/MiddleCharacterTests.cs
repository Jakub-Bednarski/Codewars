using NUnit.Framework;
using Codewars._7kyu;

namespace Codewars.tests._7kyu
{
    [TestFixture]
    class MiddleCharacterTests
    {
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual("es", MiddleCharacter.GetMiddle("test"));
            Assert.AreEqual("t", MiddleCharacter.GetMiddle("testing"));
            Assert.AreEqual("dd", MiddleCharacter.GetMiddle("middle"));
            Assert.AreEqual("A", MiddleCharacter.GetMiddle("A"));
        }
    }
}
