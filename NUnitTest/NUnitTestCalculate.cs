using NUnit.Framework;
using Bai8;

namespace NUnitTest
{
    public class Tests
    {
        
        private CalculatorService calculatorService;
        [SetUp]
        public void Setup()
        {
            calculatorService = new CalculatorService();
        }

        [TestCase(10,5)]
        [TestCase(20, 15)]
        [TestCase(8, 3)]
        public void Sub1(int value1,int value2)
        {
            Assert.AreEqual(5,calculatorService.Sub(value1,value2));
        }

        [TestCase(10, 5, ExpectedResult = 15)]
        [TestCase(10, 15, ExpectedResult = 25)]
        public int Add1(int value1, int value2)
        {
            return calculatorService.Add(value1, value2);
        }
    }
}