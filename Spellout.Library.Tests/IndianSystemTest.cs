using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spellout.Library;

namespace Spellout.Library.Tests
{
    // Unit test mehtods to test various unit of functionalities developed 
    // according to https://en.wikipedia.org/wiki/Indian_numbering_system#Use_of_separators
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

        // Tests string interpretations at tens places from 10 to 99
        [TestMethod]
        public void TestTens()
        {
            Assert.AreEqual ("ten", _testInstance.Convert("10"));
            Assert.AreEqual ("eleven", _testInstance.Convert("11"));
            Assert.AreEqual ("twelve", _testInstance.Convert("12"));
            Assert.AreEqual ("thirteen", _testInstance.Convert("13"));
            Assert.AreEqual ("fourteen", _testInstance.Convert("14"));
            Assert.AreEqual ("fifteen", _testInstance.Convert("15"));
            Assert.AreEqual ("sixteen", _testInstance.Convert("16"));
            Assert.AreEqual ("seventeen", _testInstance.Convert("17"));
            Assert.AreEqual ("eighteen", _testInstance.Convert("18"));
            Assert.AreEqual ("ninteen", _testInstance.Convert("19"));

            Assert.AreEqual ("twenty", _testInstance.Convert("20"));
            Assert.AreEqual ("thirty", _testInstance.Convert("30"));
            Assert.AreEqual ("fourty", _testInstance.Convert("40"));
            Assert.AreEqual ("fifty", _testInstance.Convert("50"));
            Assert.AreEqual ("sixty", _testInstance.Convert("60"));
            Assert.AreEqual ("seventy", _testInstance.Convert("70"));
            Assert.AreEqual ("eighty", _testInstance.Convert("80"));
            Assert.AreEqual ("ninty", _testInstance.Convert("90"));
        }
    }
}
