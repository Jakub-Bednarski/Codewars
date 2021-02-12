using NUnit.Framework;
using Codewars._6kyu;

namespace Codewars.tests._6kyu
{
    [TestFixture]
    class CamelCaseTests
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("theStealthWarrior", CamelCase.ToCamelCase("the_stealth_warrior"), "CamelCase.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.AreEqual("TheStealthWarrior", CamelCase.ToCamelCase("The-Stealth-Warrior"), "CamelCase.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }
    }
}
