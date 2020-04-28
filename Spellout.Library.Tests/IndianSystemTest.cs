using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spellout.Library;

namespace Spellout.Library.Tests
{
    [TestClass]
    public class IndianSystemTest
    {
        private readonly INumberToWord _testInstance;

        public IndianSystemTest()
        {
            _testInstance = new IndianSystem();
        }

        // Tests string interpretations at ones places from 0 to 9
        [TestMethod]
        public void TestOnes()
        {
            Assert.AreEqual ("zero", _testInstance.Convert("0"));
            Assert.AreEqual ("one", _testInstance.Convert("1"));
            Assert.AreEqual ("two", _testInstance.Convert("2"));
            Assert.AreEqual ("three", _testInstance.Convert("3"));
            Assert.AreEqual ("four", _testInstance.Convert("4"));
            Assert.AreEqual ("five", _testInstance.Convert("5"));
            Assert.AreEqual ("six", _testInstance.Convert("6"));
            Assert.AreEqual ("seven", _testInstance.Convert("7"));
            Assert.AreEqual ("eight", _testInstance.Convert("8"));
            Assert.AreEqual ("nine", _testInstance.Convert("9"));
        }
    }
}
