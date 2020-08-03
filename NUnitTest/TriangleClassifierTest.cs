using Bai8;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using System;
using System.Xml.Schema;

namespace NUnitTest
{
    class TriangleClassifierTest
    {
        private TriangleClassifier triangleClassifier;
        [SetUp]
        public void Setup()
        {
            triangleClassifier = new TriangleClassifier();
        }

        [Test]
        public void TriangleTest()
        {
            int value1 = 5;
            int value2 = 5;
            int value3 = 5;
            string tamgiacdeu = "tam giac deu";
            string result = triangleClassifier.TriangleTest(value1, value2, value3);
            Assert.AreEqual(tamgiacdeu,result);
        }
        [Test]
        public void TriangleTest1()
        {
            int value1 = 5;
            int value2 = 5;
            int value3 = 4;
            string tamgiacdeu = "tam giac can";
            string result = triangleClassifier.TriangleTest(value1, value2, value3);
            Assert.AreEqual(tamgiacdeu, result);
        }
        [Test]
        public void TriangleTest2()
        {
            int value1 = 8;
            int value2 = 3;
            int value3 = 2;
            string tamgiacdeu = "khong phai tam giac";
            string result = triangleClassifier.TriangleTest(value1, value2, value3);
            Assert.AreEqual(tamgiacdeu, result);
        }
    }
}
