using System;
using Kata5.Kata5Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata5Tests
{
    [TestClass]
    public class BloomFilterTests
    {
        [TestMethod]
        public void TestHashFunction()
        {
            //Arrange
            BloomFilter MockFilter = new BloomFilter(16);

            //Act
            int testValue = MockFilter.HashFunction("");

            //Assert
            Assert.AreEqual(0, testValue);
        }

        [TestMethod]
        public void TestAddFunction()
        {
            //Arrange
            BloomFilter MockFilter = new BloomFilter(16);

            //Act
            MockFilter.Add("");
            bool value = MockFilter.bitArray[0];

            //Assert
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void TestCheckFunction()
        {
            //Arrange
            BloomFilter MockFilter = new BloomFilter(32);

            //Act
            MockFilter.Add("Test");
            bool contains = MockFilter.Check("Test");

            //Assert
            Assert.IsTrue(contains);
        }
    }
}
