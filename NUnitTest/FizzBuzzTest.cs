using FizzBuzzB1 = Bai8.FizzBuzz;
using NUnit.Framework;
using System;
using System.Xml.Schema;
using System.Linq;

namespace NUnitTest
{
    class FizzBuzz
    {
        private FizzBuzzB1 fizzbuzz;
        [SetUp]
        public void Setup()
        {
            fizzbuzz = new FizzBuzzB1();
        }

        [Test]
        public void FizzorBuzz()
        {
            int value = 3;
            string fizz = "Fizz";
            string result = fizzbuzz.FizzorBuzz(value);
            Assert.AreEqual(fizz, result);
        }
        [TestCase(15,ExpectedResult = "FizzBuzz")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(11, ExpectedResult = "Muoi mot")]


        public string FizzorBuzz1(int value)
        {
            return fizzbuzz.FizzorBuzz(value);
        }



    }
}
