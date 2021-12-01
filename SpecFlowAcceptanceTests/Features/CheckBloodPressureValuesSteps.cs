using System;
using TechTalk.SpecFlow;
using BPCalculator;
using NUnit.Framework;

namespace SpecFlowAcceptanceTests.Features
{
    [Binding]
    public class CheckBloodPressureValuesSteps
    {
        private BloodPressure bloodPressure;

        [Given(@"user enters (.*) in Systolic")]
        public void GivenUserEntersInSystolic(String value)
        {
            int sys = Int16.Parse(value);
            bloodPressure = new BloodPressure
            {
                Systolic = sys
            };
        }
        
        [Given(@"user enters (.*) in Diastolic")]
        public void GivenUserEntersInDiastolic(String value)
        {
            int dias = Int16.Parse(value);
            bloodPressure = new BloodPressure
            {
                Diastolic = dias
            };
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            Assert.AreEqual(bloodPressure.Category.ToString(), result);        
        }
    }   
}
