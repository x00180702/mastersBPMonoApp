using BPCalculatorAcceptanceTests.PageObjects;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace BPCalculatorAcceptanceTests.Steps
{
    [Binding]
    public class BloodPressureCalcultorTestsSteps
    {

        private readonly BPCalculatorObjects _calculatorPageObject;

        [Given(@"is on the Blood Pressure Calcultor Page")]
        public void GivenIsOnTheBloodPressureCalcultorPage()
        {
            _calculatorPageObject.goToWebsite();
        }
        
        [Given(@"the user enters (.*) in the Systolic field on the Blood Pressure Calcultor Page")]
        public void GivenTheUserEntersInTheSystolicFieldOnTheBloodPressureCalcultorPage(string systolic)
        {
            _calculatorPageObject.enterSystolicNumber(systolic);
        }
        
        [Given(@"the user enters (.*) in the Diastolic field on the Blood Pressure Calcultor Page")]
        public void GivenTheUserEntersInTheDiastolicFieldOnTheBloodPressureCalcultorPage(string diastolic)
        {
            _calculatorPageObject.enterDiastolicNumber(diastolic);
        }
        
        [When(@"the clicks on the submit button on the Blood Pressure Calcultor Page")]
        public void WhenTheClicksOnTheSubmitButtonOnTheBloodPressureCalcultorPage()
        {
            _calculatorPageObject.clickSubmitButton();
        }
        
        [Then(@"the result (.*) will be diplayed on the Blood Pressure Calcultor Page")]
        public void ThenTheResultLowBloodPressureWillBeDiplayedOnTheBloodPressureCalcultorPage(string expectedValue)
        {
           string actualValue = _calculatorPageObject.getResults();
            Assert.AreEqual(actualValue, expectedValue);
        }
    }
}
