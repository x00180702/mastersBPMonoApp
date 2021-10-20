using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPCalculator;
using System;
using Xunit;

namespace bpUnitTestProject
{

    [TestClass]

    public class UnitTest1
    {
        public BloodPressure BP;

        [TestMethod]
        [Theory]
        [InlineData(70,40)] //low range
        [InlineData(82,48)] //mid range
        [InlineData(89,59)] //high range
        public void TestMethod1(int s, int d)
        {
      
            BP = new BloodPressure() { Systolic = s, Diastolic = d };
            Assert.AreEqual(BPCategory.Low, BP.Category);

        }
    }
}
