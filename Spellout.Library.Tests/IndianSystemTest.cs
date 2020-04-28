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

         // Tests string interpretations at hundreds place
        [TestMethod]
        public void TestHundred()
        {
            Assert.AreEqual ("one hundred", _testInstance.Convert("100"));
            Assert.AreEqual ("two hundred", _testInstance.Convert("200"));
            Assert.AreEqual ("nine hundred", _testInstance.Convert("900"));

            Assert.AreEqual ("one hundred eleven", _testInstance.Convert("111"));
            Assert.AreEqual ("seven hundred fifty three", _testInstance.Convert("753"));
        }

        // Tests string interpretations at thousands place
        [TestMethod]
        public void TestThousand()
        {
            Assert.AreEqual ("one thousand", _testInstance.Convert("1000"));
            Assert.AreEqual ("one thousand one hundred eleven", _testInstance.Convert("1111"));
            Assert.AreEqual ("ten thousand", _testInstance.Convert("10000"));
            Assert.AreEqual ("eleven thousand one hundred eleven", _testInstance.Convert("11111"));
        }

        // Tests string interpretations at lac place
        [TestMethod]
        public void TestLac()
        {
            Assert.AreEqual ("ten lac eleven thousand one hundred eleven", _testInstance.Convert("1011111"));
            Assert.AreEqual ("one lac", _testInstance.Convert("100000"));
            Assert.AreEqual ("ten lac", _testInstance.Convert("1000000"));
        }

        // Tests string interpretations at crore place
        [TestMethod]
        public void TestCrore()
        {
            Assert.AreEqual ("one crore", _testInstance.Convert("10000000"));
            Assert.AreEqual ("ten crore", _testInstance.Convert("100000000"));
        }          

        // Tests string interpretations at arab place
        [TestMethod]
        public void TestArab()
        {
            Assert.AreEqual ("one arab", _testInstance.Convert("1000000000"));
            Assert.AreEqual ("ten arab", _testInstance.Convert("10000000000"));
        }

        // Tests string interpretations at kharab place
        [TestMethod]
        public void TestKharab()
        {
            Assert.AreEqual ("one kharab", _testInstance.Convert("100000000000"));
            Assert.AreEqual ("ten kharab", _testInstance.Convert("1000000000000"));
        }

        // Tests string interpretations at nil place
        [TestMethod]
        public void TestNil()
        {
            Assert.AreEqual ("one nil", _testInstance.Convert("10000000000000"));
            Assert.AreEqual ("ten nil", _testInstance.Convert("100000000000000"));
        }

        // Tests string interpretations at padma place
        [TestMethod]
        public void TestPadma()
        {
            Assert.AreEqual ("one padma", _testInstance.Convert("1000000000000000"));
            Assert.AreEqual ("ten padma", _testInstance.Convert("10000000000000000"));
        } 

        // Tests string interpretations at shankh place
        [TestMethod]
        public void TestShankh()
        {
            Assert.AreEqual ("one shankh", _testInstance.Convert("100000000000000000"));
            Assert.AreEqual ("one shankh eleven padma eleven nil eleven kharab eleven arab eleven crore eleven lac eleven thousand one hundred eleven", _testInstance.Convert("111111111111111111"));
            Assert.AreEqual ("ten shankh", _testInstance.Convert("1000000000000000000"));
        }
    }
}
