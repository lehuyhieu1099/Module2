using NUnit.Framework;
using Bai8;

namespace NUnitTest
{
    public class TestAbsolute
    {

        private AbsoluteNumberCalulator absoluteNumberCalulator;
        [SetUp]
        public void Setup()
        {
            absoluteNumberCalulator = new AbsoluteNumberCalulator();
        }

        [TestCase(8)]
        [TestCase(-8)]
        public void Abs1(int value)
        {
            int abs = absoluteNumberCalulator.FindAbsolute(value);
            Assert.AreEqual(8, abs );
        }
    }
}