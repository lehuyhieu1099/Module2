
using Bai8;
using NUnit.Framework;
using System;
using System.Xml.Schema;

namespace NUnitTest
{
    class NUnitNextDayCalculatorTest
    {
        private NextDayCalculatorService nextDayCalculatorService;
        [SetUp]
        public void Setup()
        {
            nextDayCalculatorService = new NextDayCalculatorService();
        }

        [Test]
        public void nextDay_1()
        {
            DateTime toDay = new DateTime(2018, 4, 30);
            DateTime nextDay = new DateTime (2018,5,1);
            Assert.AreEqual(nextDay, nextDayCalculatorService.nextDay(toDay));
        }
        [Test]
        public void nextDay_2()
        {
            DateTime toDay = new DateTime(2018, 1, 1);
            DateTime nextDay = new DateTime(2018, 1, 2);
            Assert.AreEqual(nextDay, nextDayCalculatorService.nextDay(toDay));
        }
        [Test]
        public void nextDay_3()
        {
            DateTime toDay = new DateTime(2018, 2, 28);
            DateTime nextDay = new DateTime(2018, 3, 1);
            Assert.AreEqual(nextDay, nextDayCalculatorService.nextDay(toDay));
        }
    }
}
