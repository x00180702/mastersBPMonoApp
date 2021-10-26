using BPCalculator;
using Xunit;

namespace bpUnitTestProject
{

    public class UnitTest1
    {
        public BloodPressure BP;
        [Theory]
        [InlineData(70,40)] //low range
        [InlineData(82,48)] //mid range
        [InlineData(89,59)] //high range
        public void TestMethodLowVariables(int s, int d)
        {
      
            BP = new BloodPressure() { Systolic = s, Diastolic = d };
            Assert.Equal(BPCategory.Low, BP.Category);

        }

        [Theory]
        [InlineData(90, 60)] //low range
        [InlineData(105, 62)] //mid range
        [InlineData(119, 79)] //high range
        public void TestMethodIdealVariables(int s, int d)
        {

            BP = new BloodPressure() { Systolic = s, Diastolic = d };
            Assert.Equal(BPCategory.Ideal, BP.Category);

        }
    }
}
