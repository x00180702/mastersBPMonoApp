using BPCalculator;
using Xunit;

namespace bpUnitTestProject
{

    public class UnitTest1
    {
        public BloodPressure BP;

        //Unit test to check LOW blood pressure
        [Theory]
        [InlineData(70,40)] //low range
        [InlineData(82,48)] //mid range
        [InlineData(89,59)] //high range
        public void TestMethodLowVariables(int s, int d)
        {
      
            BP = new BloodPressure() { Systolic = s, Diastolic = d };
            Assert.Equal(BPCategory.Low, BP.Category);

        }

        //Unit test to check IDEAL blood pressure
        [Theory]
        [InlineData(90, 60)] //low range
        [InlineData(105, 62)] //mid range
        [InlineData(119, 79)] //high range
        public void TestMethodIdealVariables(int s, int d)
        {

            BP = new BloodPressure() { Systolic = s, Diastolic = d };
            Assert.Equal(BPCategory.Ideal, BP.Category);

        }

        //Unit test to check PRE HIGH blood pressure
        [Theory]
        [InlineData(120, 80)] //low range
        [InlineData(134, 86)] //mid range
        [InlineData(139, 89)] //high range
        public void TestMethodPreHighlVariables(int s, int d)
        {

            BP = new BloodPressure() { Systolic = s, Diastolic = d };
            Assert.Equal(BPCategory.PreHigh, BP.Category);

        }

        //Unit test to check High blood pressure
        [Theory]
        [InlineData(140, 90)] //low range
        [InlineData(173, 97)] //mid range
        [InlineData(190, 100)] //high range
        public void TestMethodHighVariables(int s, int d)
        {

            BP = new BloodPressure() { Systolic = s, Diastolic = d };
            Assert.Equal(BPCategory.High, BP.Category);

        }

        //Unit test to check InValid blood pressure
        [Theory]
        [InlineData(195, 39)] //low range
        [InlineData(200, 23)] //mid range
        [InlineData(191, 101)] //high range
        public void TestMethodInvalidVariables(int s, int d)
        {

            BP = new BloodPressure() { Systolic = s, Diastolic = d };
            Assert.Equal(BPCategory.NotValid, BP.Category);

        }

        //Negative Tests 

        [Theory]
        [InlineData(70, 40)]
        [InlineData(139, 89)]
        public void Test_for_values_outside_high_range(int s, int d)
        {
            BP = new BloodPressure() { Systolic = s, Diastolic = d };
            Assert.InRange(d,BloodPressure.DiastolicMin, BPCalculator.BloodPressure.DiastolicMax);
            Assert.NotEqual(BPCategory.High, BP.Category);
        }

        [Theory]
        [InlineData(70, 40)]
        [InlineData(119, 79)]
        [InlineData(140, 90)]
        public void Test_for_values_outside_prehigh_range(int s, int d)
        {
            BP = new BloodPressure() { Systolic = s, Diastolic = d };
            Assert.InRange(d, BloodPressure.DiastolicMin, BPCalculator.BloodPressure.DiastolicMax);
            Assert.NotEqual(BPCategory.PreHigh, BP.Category);
        }

        [Theory]
        [InlineData(70, 40)]
        [InlineData(89, 59)]
        [InlineData(120, 81)]
        public void Test_for_values_outside_ideal_range(int s, int d)
        {
            BP = new BloodPressure() { Systolic = s, Diastolic = d };
            Assert.InRange(d, BloodPressure.DiastolicMin, BPCalculator.BloodPressure.DiastolicMax);
            Assert.NotEqual(BPCategory.Ideal, BP.Category);
        }

        [Theory]
        [InlineData(90, 60)]
        [InlineData(139, 89)]
        public void Test_for_values_outside_low_range(int s, int d)
        {
            BP = new BloodPressure() { Systolic = s, Diastolic = d };
            Assert.InRange(d, BloodPressure.DiastolicMin, BPCalculator.BloodPressure.DiastolicMax);
            Assert.NotEqual(BPCategory.Low, BP.Category);
        }
    }
}
